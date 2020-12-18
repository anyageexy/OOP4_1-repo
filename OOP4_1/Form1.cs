using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP4_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Функция обработки получения координат XY события передвижения курсора по панели
        private void Circle_Panel_MouseMove(object sender, MouseEventArgs e)
        {
            Coord_label.Text = "X: " + e.X + " Y: " + e.Y;
        }

        //Функция обработки события передвижения курсора по форме(очищение метки)
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            Coord_label.Text = "";
        }

        //Инициализация необходимых переменных
        static int amtCells = 1;
        int CountElem = 0;
        int item = 0;
        static readonly Color DefaultColor = Color.White;
        static readonly Color SelectedColor = Color.Red;
        myStorage storage = new myStorage(amtCells);

        //Обработчик события Click кнопки "Очистить панель".
        private void Clear_button_Click(object sender, EventArgs e)
        {
            Circle_Panel.Refresh(); //перерисовка
            for (int i = 0; i < amtCells; ++i)
                if (!storage.Empty(i))
                {
                    storage.objects[i].Is_Drawn = false;
                    storage.objects[i].color = DefaultColor;
                }
        }

        //Обработчик события Click кнопки "Удалить объекты" (удаление выделенных объектов)
        private void Del_button_Click(object sender, EventArgs e)
        {
            //Если объект существует и окрашен в цвет выбранных объектов,то происходит..
            if (storage.OccupiedCells(amtCells) != 0)
                for (int i = 0; i < amtCells; ++i)
                    if (storage.Empty(i) == false && storage.objects[i].color == SelectedColor)
                        storage.DeleteObj(ref i); //удаление объекта из хранилища
            Clear_button_Click(sender, e); //Очищение панели
            ShowCircle_button_Click(sender, e); //Показ объектов хранилища
        }

        //Обработчик события Click кнопки "Очистить хранилище" 
        private void СlearStorage_button_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < amtCells; ++i) //Для всех объектов хранилища
                storage.DeleteObj(ref i); //Удаление объекта из хранилища
            CountElem = 0; //Обнуляем счетчик, отвечающий за количество объектов в хранилище
        }

        //Обработчик события Click кнопки "Показать объекты хранилища" 
        private void ShowCircle_button_Click(object sender, EventArgs e)
        {
            //Сначала очищается панель
            Circle_Panel.Refresh();

            //Если хранилище не пустое, то..
            if (storage.OccupiedCells(amtCells) != 0)
                for (int i = 0; i < amtCells; ++i)
                {
                    DrawingCircles(ref storage, i); //рисуется окружность,
                    if (!storage.Empty(i))
                        storage.objects[i].Is_Drawn = true; //устанавливается флаг(объект отрисован)
                }
        }

        //Функция отрисовки окружности на панели
        private void DrawingCircles(ref myStorage storage, int CountElem)
        {
            //Если ячейка хранилища не пуста, то..
            if (storage.objects[CountElem] != null)
            {
                //создаем ручку, отрисовываем окружность с указанными параметрами
                Pen pen = new Pen(storage.objects[CountElem].color, 3);
                Circle_Panel.CreateGraphics().DrawEllipse(pen, storage.objects[CountElem].x,
                    storage.objects[CountElem].y, storage.objects[CountElem].R * 2, storage.objects[CountElem].R * 2);
            }
        }

        //Функция, убирающая выделение объектов
        private void SelectionRemove(ref myStorage storage)
        {
            for (int i = 0; i < amtCells; ++i)
                //Если хранилище не пусто, то происходит..
                if (!storage.Empty(i))
                {
                    storage.objects[i].color = DefaultColor; //установка стандартного цвета
                    if (storage.objects[i].Is_Drawn == true)
                        DrawingCircles(ref storage, i); //перерисовка окружности
                }
        }

        //Функция, возвращающая значение индекса объекта в хранилище и сранвивает координаты
        private int CheckCircle(ref myStorage storage, int Size, int x, int y)
        {
            if (storage.OccupiedCells(Size) != 0)
            {
                for (int i = 0; i < Size; ++i)
                    if (!storage.Empty(i)) //Если хранилище не пусто
                    {
                        if (Math.Sqrt(Math.Pow((x - storage.objects[i].x), 2) + Math.Pow((y - storage.objects[i].y), 2)) <= storage.objects[i].R)
                            return i;
                    }
            }
            return -1;
        }

        //Функция обработки события нажатия курсора на панель
        private void Circle_Panel_MouseDown(object sender, MouseEventArgs e)
        {
            //Создается объект класса CCircle
            CCircle circle = new CCircle(e.X, e.Y, DefaultColor);

            //Получение индекса объекта
            int SellectedItem = CheckCircle(ref storage, amtCells, circle.x, circle.y);
            if (SellectedItem != -1)
            {
                //Если нажат ctrl, выделяем несколько объектов
                if (Control.ModifierKeys == Keys.Control)
                {
                    int x = e.X - circle.R;
                    int y = e.Y - circle.R;
                    for (int i = 0; i < amtCells; ++i)
                        if (!storage.Empty(i))
                        {
                            //проверка условия
                            if (Math.Sqrt(Math.Pow((x - storage.objects[i].x), 2) + Math.Pow((y - storage.objects[i].y), 2)) <= storage.objects[i].R)
                            {
                                storage.objects[i].color = SelectedColor; //установка цвета выделенного объекта
                                DrawingCircles(ref storage, i); //перерисовка окружности
                            }
                        }
                }
                else
                {
                    //Иначе выделяем 1 объект и снимаем выделение у остальных объектов хранилища
                    int x = e.X - circle.R;
                    int y = e.Y - circle.R;
                    SelectionRemove(ref storage);
                    for (int i = 0; i < amtCells; ++i)
                        if (!storage.Empty(i))
                        {
                            if (Math.Sqrt(Math.Pow((x - storage.objects[i].x), 2) + Math.Pow((y - storage.objects[i].y), 2)) <= storage.objects[i].R)
                            {
                                storage.objects[i].color = SelectedColor; //установка цвета выделенного объекта
                                DrawingCircles(ref storage, i); //перерисовка окружности
                                break;
                            }
                        }
                    //Перерисовываем окружность
                    storage.objects[SellectedItem].color = SelectedColor;
                    DrawingCircles(ref storage, SellectedItem);
                }
                return;
            }
            //Добавляем окружность в хранилище
            storage.AddObj(CountElem, ref circle, ref amtCells, ref item);

            //Снимаем выделение всех объектов хранилища
            SelectionRemove(ref storage);

            //Устанавливаем цвет выделяемого объекта на новый добавленный
            storage.objects[item].color = SelectedColor;

            //Отрисовываем окружность
            DrawingCircles(ref storage, item);

            //Увеличиваем счетчик количества объектов хранилища
            ++CountElem;
        }


        public class CCircle
        {
            public int R = 80; //Задаем постоянный радиус
            public int x, y;
            public Color color = DefaultColor; //Установка цвета по умолчанию
            public bool Is_Drawn = true; //Проверка на отрисовку окружности на панели

            //Конструктор по умолчанию
            public CCircle()
            {
                x = 0;
                y = 0;
            }

            //Конструктор с параметрами
            public CCircle(int x, int y, Color color)
            {
                this.x = x - R;
                this.y = y - R;
                this.color = color;
            }

            //Деструктор
            ~CCircle() { }
        }

        //Класс хранилища
        class myStorage
        {
            public CCircle[] objects;

            //Конструктор с параметром
            public myStorage(int amt)
            {
                objects = new CCircle[amt];
                for (int i = 0; i < amt; ++i)
                    objects[i] = null;
            }

            //Функция для выделения мест хранилища
            public void Allocation(int amt)
            {
                objects = new CCircle[amt];
                for (int i = 0; i < amt; ++i)
                    objects[i] = null;
            }

            //Функция добавления объекта в хранилище 
            public void AddObj(int index, ref CCircle NewObj, ref int Count, ref int item)
            {
                myStorage NewStorage = new myStorage(Count + 1);
                for (int i = 0; i < Count; ++i)
                    NewStorage.objects[i] = objects[i];
                for (int i = Count; i < (Count + 1) - 1; ++i)
                {
                    NewStorage.objects[i] = null;
                }

                Count = Count + 1;
                Allocation(Count);
                for (int i = 0; i < Count; ++i)
                    objects[i] = NewStorage.objects[i];
                objects[index] = NewObj;

                item = index;
            }

            //Функция удаления объекта из хранилища
            public void DeleteObj(ref int amtElem)
            {
                if (objects[amtElem] != null)
                {
                    objects[amtElem] = null;
                    amtElem--;
                }
            }

            //Функции проверки на занятость места в хранилище
            public bool Empty(int CountElem)
            {
                if (objects[CountElem] == null)
                    return true;
                else return false;
            }

            //Функция, определяющая кол-во занятых мест в хранилище
            public int OccupiedCells(int Size)
            {
                int amtOccupied = 0;
                for (int i = 0; i < Size; ++i)
                    if (!Empty(i))
                        ++amtOccupied;
                return amtOccupied;
            }

            //Деструктор
            ~myStorage() { }
        };
    }
}