using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_oop_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int p = 0;
        static int k = 5;
        Storage storag = new Storage(k);
        static int index = 0;
        int indexin = 0;
        int figure_now = 0;

        class Figure
        {
            public Color color = Color.Navy;
            public Color fillcolor = Color.White;
        }
        class Circle : Figure
        {
            public int x, y; // Координаты круга
            public int rad = 15; // Радиус круга
            public Circle(int x, int y)
            {
                this.x = x - rad;
                this.y = y - rad;
            }

            ~Circle() { }
        }

        class Line : Figure
        {
            public int x, y;
            public int lenght = 60;
            public int wight = 5;
            public Line(int x, int y)
            {
                this.x = x - lenght / 2;
                this.y = y;
            }
        }

        class Square : Figure
        {
            public int x, y, width, height;
            public int size = 60;
            public Square(int x, int y)
            {
                this.x = x - size / 2;
                this.y = y - size / 2;
                this.width = size;
                this.height = size;
            }
        }

        class Storage
        {
            public Figure[] objects;
            public Storage(int count)
            {
                objects = new Figure[count];
                for (int i = 0; i < count; ++i)
                    objects[i] = null;
            }
            public void initialisat(int count)
            {//выделяем место
                objects = new Figure[count];
                for (int i = 0; i < count; ++i)
                    objects[i] = null;
            }
            public void add_object(int ind, ref Figure object1, int count, ref int indexin)
            {//добавляет объект
                while (objects[ind] != null)
                {//если ячейка занята, ищем новое место
                    ind = (ind + 1) % count;
                }
                objects[ind] = object1;
                indexin = ind;
            }
            public void delete_object(int ind)
            {//удаляет объект из хранилища
                objects[ind] = null;
                index--;
            }
            public bool check_empty(int index)
            {//занято ли место
                if (objects[index] == null)
                    return true;
                else
                    return false;
            }
            public int occupied(int size)
            {//кол-во занятых мест
                int count_occupied = 0;
                for (int i = 0; i < size; ++i)
                    if (!check_empty(i))
                        ++count_occupied;
                return count_occupied;
            }
            public void increase(ref int size)
            {//расширение хранилища
                Storage storage1 = new Storage(size + 10);
                for (int i = 0; i < size; ++i)
                    storage1.objects[i] = objects[i];
                for (int i = size; i < (size + 10) - 1; ++i)
                {
                    storage1.objects[i] = null;
                }
                size = size + 10;
                initialisat(size);
                for (int i = 0; i < size; ++i)
                    objects[i] = storage1.objects[i];
            }
            ~Storage() { }
        };

        private void paint_figure(Color name, ref Storage stg, int index)
        {//рисуем круг на панели
            Pen pen = new Pen(name, 3);
            SolidBrush figurefillcolor;
            if (!stg.check_empty(index))
            {
                stg.objects[index].color = name;
                figurefillcolor = new SolidBrush(stg.objects[index].fillcolor);
                if (storag.objects[index] as Circle != null)
                {// Если в хранилище круг
                    Circle circle = stg.objects[index] as Circle;
                    paint_box.CreateGraphics().DrawEllipse(
                    pen, circle.x, circle.y, circle.rad * 2, circle.rad * 2);
                    paint_box.CreateGraphics().FillEllipse(
                        figurefillcolor, circle.x, circle.y, circle.rad * 2, circle.rad * 2);
                }
                else 
                {
                    if (stg.objects[index] as Line != null)
                    {   // Если в хранилище линия
                        Line line = stg.objects[index] as Line;
                        paint_box.CreateGraphics().DrawRectangle(pen, line.x,
                                                line.y, line.lenght, line.wight);
                        paint_box.CreateGraphics().FillRectangle(figurefillcolor, line.x,
                            line.y, line.lenght, line.wight);
                    }
                }
            }
        }

        //private void drawellipse_Click(object sender, EventArgs e)
        //{
        //    //drawline.Checked = false;
        //    //figure_now = 1;
        //    //if (drawellipse.Checked == false) // Если не выбрана фигура
        //    //    figure_now = 0;
        //}

        //private void drawline_Click(object sender, EventArgs e)
        //{
        //    //drawellipse.Checked = false;
        //    //figure_now = 2;
        //    //if (drawline.Checked == false) // Если не выбрана фигура
        //    //    figure_now = 0;
        //}



        private void button_deletestorage_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < k; ++i)
            {
                storag.objects[i] = null;
            }
            index = 0;

        }

        private void button_del__item_storage_Click(object sender, EventArgs e)
        {
            remove_selected_circle(ref storag);
            paint_box.Refresh();
            if (storag.occupied(k) != 0)
            {
                for (int i = 0; i < k; ++i)
                {
                    paint_figure(Color.Navy, ref storag, i);
                }
            }
        }

        private void remove_selected_circle(ref Storage stg)
        {//удаляет выделенные элементы
            for (int i = 0; i < k; ++i)
            {
                if (!stg.check_empty(i))
                {
                    if (stg.objects[i].color == Color.Red)
                    {
                        stg.delete_object(i);
                    }
                }
            }
        }









        private void paint_box_MouseClick(object sender, MouseEventArgs e)
        {
            //проверка на наличие круга на данных координатах
            int c = check_figure(ref storag, k, e.X, e.Y);
            if (index == k)
                storag.increase(ref k);
            if (c != -1)
            {//круг уже есть
                if (Control.ModifierKeys == Keys.Control)
                {//если нажат, выделяем несколько объектов
                    if (p == 0)
                    {
                        paint_figure(Color.Navy, ref storag, indexin);
                        p = 1;
                    }
                    paint_figure(Color.Red, ref storag, c);
                }
                else
                {//иначе только один объект
                    remove_selection_circle(ref storag);

                    paint_figure(Color.Red, ref storag, c);
                }
                return;
            }
            else
            {//круга нет
                Figure figure = new Figure();
                switch (figure_now)
                {   // В зависимости какая фигура выбрана
                    case 0:
                        return;
                    case 1:
                        figure = new Circle(e.X, e.Y);
                        break;
                    case 2:
                        figure = new Line(e.X, e.Y);
                        break;
                }
                storag.add_object(index, ref figure, k, ref indexin);

                remove_selection_circle(ref storag);

                paint_figure(Color.Red, ref storag, indexin);
                ++index;

            }
            p = 0;
        }









        private int check_figure(ref Storage stg, int size, int x, int y)
        {//проверка на наличие круга с координатами в хранилище
            if (stg.occupied(size) != 0)
            {
                for (int i = 0; i < size; ++i)
                {
                    if (!stg.check_empty(i))
                    {
                        if (stg.objects[i] as Circle != null)
                        {
                            Circle circle = stg.objects[i] as Circle;
                            if (((x - circle.x - circle.rad) * (x - circle.x - circle.rad) + (y - circle.y - circle.rad) * (y - circle.y - circle.rad)) < (circle.rad * circle.rad))
                                return i;
                        }
                        else
                        {
                            if (stg.objects[i] as Line != null)
                            {
                                Line line = stg.objects[i] as Line;
                                if (line.x <= x && x <= (line.x + line.lenght) && (line.y - 2) <= y && y <= (line.y + line.wight))
                                    return i;
                            }
                        }


                    }
                }
            }
            return -1;
        }

        private void remove_selection_circle(ref Storage stg)
        {//снимает выделение
            for (int i = 0; i < k; ++i)
            {
                if (!stg.check_empty(i))
                {
                    paint_figure(Color.Navy, ref storag, i);
                }
            }
        }


        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {//кнопка Delete
            if (e.KeyCode == Keys.Delete)
            {
                remove_selected_circle(ref storag);
                paint_box.Refresh();
                if (storag.occupied(k) != 0)
                {
                    for (int i = 0; i < k; ++i)
                    {
                        paint_figure(Color.Navy, ref storag, i);
                    }
                }
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            toolStripButton2.Checked = false;
            figure_now = 1;
            if (toolStripButton1.Checked == false) // Если не выбрана фигура
                figure_now = 0;
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            toolStripButton1.Checked = false;
            figure_now = 2;
            if (toolStripButton2.Checked == false) // Если не выбрана фигура
                figure_now = 0;
        }
    }
}
