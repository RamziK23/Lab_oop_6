﻿using System;
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

        class Circle
        {
            public int x, y;
            public int rad = 15;
            public Color color = Color.Navy;
            public bool is_drawed = true;
            public Circle()
            {
                x = 0;
                y = 0;
            }
            public Circle(int x, int y)
            {
                this.x = x - rad;
                this.y = y - rad;
            }

            ~Circle() { }
        }

        class Storage
        {
            public Circle[] objects;
            public Storage(int count)
            {
                objects = new Circle[count];
                for (int i = 0; i < count; ++i)
                    objects[i] = null;
            }
            public void initialisat(int count)
            {//выделяем место
                objects = new Circle[count];
                for (int i = 0; i < count; ++i)
                    objects[i] = null;
            }
            public void add_object(int ind, ref Circle object1, int count, ref int indexin)
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
            public void doubleSize(ref int size)
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

        private void paint_circle(Color name, ref Storage stg, int index)
        {//рисуем круг на панели
            Pen pen = new Pen(name, 3);

            if (!storag.check_empty(index))
            {
                if (storag.objects[index].is_drawed == true)
                {
                    paint_box.CreateGraphics().DrawEllipse(
                    pen,
                    stg.objects[index].x,
                    stg.objects[index].y,
                    stg.objects[index].rad * 2,
                    stg.objects[index].rad * 2);
                    stg.objects[index].color = name;
                }
            }
        }

        private void button_show_Click(object sender, EventArgs e)
        {
            paint_box.Refresh();
            if (storag.occupied(k) != 0)
            {
                for (int i = 0; i < k; ++i)
                {
                    if (!storag.check_empty(i))
                    {
                        storag.objects[i].is_drawed = true;
                    }
                    paint_circle(Color.Navy, ref storag, i);
                }
            }
        }

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
                    paint_circle(Color.Navy, ref storag, i);
                }
            }
        }

        private void button_clear_paintbox_Click(object sender, EventArgs e)
        {
            paint_box.Invalidate();
            paint_box.Refresh();
            for (int i = 0; i < k; ++i)
            {
                if (!storag.check_empty(i))
                {
                    storag.objects[i].is_drawed = false;
                }
            }
        }

        private void remove_selected_circle(ref Storage stg)
        {//удаляет выделенные элементы
            for (int i = 0; i < k; ++i)
            {
                if (!storag.check_empty(i))
                {
                    if (storag.objects[i].color == Color.Red)
                    {
                        storag.delete_object(i);
                    }
                }
            }
        }

        private void paint_box_MouseClick(object sender, MouseEventArgs e)
        {
            //проверка на наличие круга на данных координатах
            int c = check_circle(ref storag, k, e.X - 15, e.Y - 15);
            if (index == k)
                storag.doubleSize(ref k);
            if (c != -1)
            {//круг уже есть
                if (Control.ModifierKeys == Keys.Control)
                {//если нажат, выделяем несколько объектов
                    if (p == 0)
                    {
                        paint_circle(Color.Navy, ref storag, indexin);
                        p = 1;
                    }
                    paint_circle(Color.Red, ref storag, c);
                }
                else
                {//иначе только один объект
                    remove_selection_circle(ref storag);

                    paint_circle(Color.Red, ref storag, c);
                }
                return;
            }
            else
            {//круга нет
                Circle krug = new Circle(e.X, e.Y);

                storag.add_object(index, ref krug, k, ref indexin);

                remove_selection_circle(ref storag);

                paint_circle(Color.Red, ref storag, indexin);
                ++index;

            }
            p = 0;
        }

        private int check_circle(ref Storage stg, int size, int x, int y)
        {//проверка на наличие круга с координатами в хранилище
            if (stg.occupied(size) != 0)
            {
                for (int i = 0; i < size; ++i)
                {
                    if (!stg.check_empty(i))
                    {
                        int x1 = stg.objects[i].x - 15;
                        int x2 = stg.objects[i].x + 15;
                        int y1 = stg.objects[i].y - 15;
                        int y2 = stg.objects[i].y + 15;
                        //если круг есть, возвращает индекс круга
                        if ((x1 <= x && x <= x2) && (y1 <= y && y <= y2))
                            return i;
                    }
                }
            }
            return -1;
        }

        private void remove_selection_circle(ref Storage stg)
        {//снимает выделение
            for (int i = 0; i < k; ++i)
            {
                if (!storag.check_empty(i))
                {
                    paint_circle(Color.Navy, ref storag, i);
                }
            }
        }


        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {//кнопка Delete
            if (e.KeyValue == (char)Keys.Delete)
            {
                remove_selected_circle(ref storag);
                paint_box.Refresh();
                if (storag.occupied(k) != 0)
                {
                    for (int i = 0; i < k; ++i)
                    {
                        paint_circle(Color.Navy, ref storag, i);
                    }
                }
            }
        }
    }
}
