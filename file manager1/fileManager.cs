using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;//для того чтобы запускать процессы

namespace file_manager1
{
    public partial class fileManager : Form
    {
        public fileManager()
        {
            InitializeComponent();
        }
        //загрузка файлов и папок-кнопка "перейти"
        private void goDir_Click(object sender, EventArgs e)
        {
            listDir.Items.Clear();//чтобы при загрузки новой директории и это не наслаивалось, поэтому отчищаем
            DirectoryInfo dir = new DirectoryInfo(addressDir.Text);//для того чтобы работать с папками и файлами
            DirectoryInfo[] dirs = dir.GetDirectories();//массив каталогов, в этот массив каталогов мы положим все папки которые есть в дир
            foreach(DirectoryInfo currentDir in dirs)
            {
                listDir.Items.Add(currentDir);   //мы в наш лист добавляем элемент
            }
            FileInfo[] files = dir.GetFiles();//масиив файлов, чтобы потом его отобразить
            foreach(FileInfo currentFile in files)
            {
                listDir.Items.Add(currentFile);//получаем файлы в лист
            }
        }

        private void listDir_MouseDoubleClick(object sender, MouseEventArgs e)
        { if (Path.GetExtension(Path.Combine(addressDir.Text + listDir.SelectedItem.ToString())) == "")//тут он проверяет есть ли у файла расширение
            {
                addressDir.Text = Path.Combine(addressDir.Text + listDir.SelectedItem.ToString());//пользователь кликает на какой-то элемент,
                                                                                               //этот элемент выделяется и дальше мы добавляем к адресной строке его имя
                listDir.Items.Clear();                                                        //у класса Path метод комбайн - это составление адреса из набора каких-то строк
                DirectoryInfo dir = new DirectoryInfo(addressDir.Text);
                DirectoryInfo[] dirs = dir.GetDirectories();
                foreach (DirectoryInfo crrDir in dirs)
                {
                    listDir.Items.Add(crrDir);
                }
                FileInfo[] files = dir.GetFiles();
                foreach (FileInfo crrFile in files)
                {
                    listDir.Items.Add(crrFile);
                }
            }
        else
            {
                Process.Start(Path.Combine(addressDir.Text + listDir.SelectedItem.ToString()));//процесс это класс систем диагностикс
            }
        }
            

        private void backDir_Click(object sender, EventArgs e)
        {
            if (addressDir.Text[addressDir.Text.Length - 1] == '\\')//когда есть слеш после адреса, -1, потому что в массивах нумерациЯ с нуля
            {
                addressDir.Text = addressDir.Text.Remove(addressDir.Text.Length - 1, 1);//мы сначала стираем слеш
                while (addressDir.Text[addressDir.Text.Length - 1] != '\\')//работаем со строкой как с массивом
                {
                    addressDir.Text = addressDir.Text.Remove(addressDir.Text.Length - 1, 1);//цикл файл работает до ней пор пока не встретит слеш
                }

            }
            else if (addressDir.Text[addressDir.Text.Length - 1] != '\\')//когда нет слеша, мы просто стираем адресную строку, пока не будет встречен слеш
            {
                addressDir.Text = addressDir.Text.Remove(addressDir.Text.Length - 1, 1);
            }
            listDir.Items.Clear();             //и потом загружаем содержимое папки
            DirectoryInfo dir = new DirectoryInfo(addressDir.Text);
            DirectoryInfo[] dirs = dir.GetDirectories();
            foreach (DirectoryInfo crrDir in dirs)
            {
                listDir.Items.Add(crrDir);
            }
            FileInfo[] files = dir.GetFiles();
            foreach (FileInfo crrFile in files)
            {
                listDir.Items.Add(crrFile);
            }


        }
    }
}
