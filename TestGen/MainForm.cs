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

namespace TestGen
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        // QuantityOfTickets количество билетов
        //QuantityTheoreticalQuestions количество теоретических вопросов в одном билете
        //QuantityPracticalQuestions количество практических вопросов в одном билете
        public string pathToTemplate;
        public int QuantityOfTickets, QuantityOfTheoreticalQuestions, QuantityOfPracticalQuestions;

        private void OpenTemplate_Click(object sender, EventArgs e)
        {
            OpenFileDialog openTemplate = new OpenFileDialog();
            openTemplate.InitialDirectory = System.IO.Path.GetDirectoryName(Application.ExecutablePath);
            openTemplate.Filter = "All file (*.*) | *.*| doc|*.doc";
            openTemplate.FilterIndex = 2;
            if (openTemplate.ShowDialog() == DialogResult.OK)
            {
                pathToTemplate = openTemplate.FileName;
            }
        }

        public double tmp;
        public Random r = new Random();
        public int temp;

        //формирование списка теоретических вопросов(в виде массива строк)
        public string[] TheoreticalQuestions;
        private void OpenTheoreticalQuestions_Click(object sender, EventArgs e)
        {
            OpenFileDialog OpenTheoreticalQuestions = new OpenFileDialog();
            OpenTheoreticalQuestions.Filter = "All file (*.*) | *.*| Text file |*.txt";
            OpenTheoreticalQuestions.FilterIndex = 2;
            if (OpenTheoreticalQuestions.ShowDialog() == DialogResult.OK)
            {
                //label3.Text += OpenTheoreticalQuestions.FileName;
                TheoreticalQuestions = System.IO.File.ReadAllLines(OpenTheoreticalQuestions.FileName, System.Text.Encoding.GetEncoding(1251));
            }
        }

        // формирование списка практических вопросов(в виде массива строк)
        public string[] PracticalQuestions;
        private void OpenPracticalQuestions_Click(object sender, EventArgs e)
        {
            OpenFileDialog OpenPracticalQuestions = new OpenFileDialog();
            OpenPracticalQuestions.Filter = "All file (*.*) | *.*| Text file |*.txt";
            OpenPracticalQuestions.FilterIndex = 2;
            if (OpenPracticalQuestions.ShowDialog() == DialogResult.OK)
            {
                //label4.Text += OpenPracticalQuestions.FileName;
                PracticalQuestions = System.IO.File.ReadAllLines(OpenPracticalQuestions.FileName, System.Text.Encoding.GetEncoding(1251));
            }
        }

        // QuantityOfTickets количество билетов
        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                QuantityOfTickets = Convert.ToInt32(textBox1.Text);
            }
            catch
            {
                //MessageBox.Show(ex.Message);
            }
        }

        //кол теоретических вопросов в билете
        private void textBox2_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                QuantityOfTheoreticalQuestions = Convert.ToInt32(textBox2.Text);
            }
            catch// (Exception ex)
            {
                //  MessageBox.Show(ex.Message);
            }

        }

        //кол практических вопросов в билете
        private void textBox3_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                QuantityOfPracticalQuestions = Convert.ToInt32(textBox3.Text);
            }
            catch// (Exception ex)
            {
                //  MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        public int[] SequenceTheoreticalQuestions;
        public void CreateSequenceTheoreticalQuestions()
        {
            int step = 0, q = 0;
            int k;
            double w;
            //  if (TheoreticalQuestions.Length != 0)
            {
                int[] x = new int[TheoreticalQuestions.Length];

                step = 0; q = 0;

                // определяем сколько раз необходимо продублировать все вопросы,
                //чтобы заполнить необходимое число экзаменационных билетов

                w = (QuantityOfTickets * QuantityOfTheoreticalQuestions) / Convert.ToDouble(TheoreticalQuestions.Length);
                k = Convert.ToInt32(Math.Ceiling(w));

                //SequenceTheoreticalQuestions Последовательность теоретических вопросов

                SequenceTheoreticalQuestions = new int[QuantityOfTickets * QuantityOfTheoreticalQuestions];

                for (int j = 0; j < k; j++)
                {
                    //заполняем без повторов массив от 0 до n, 
                    //где n — количество теоретических вопросов.
                    for (int i = 0; i < TheoreticalQuestions.Length; i++)
                    {
                        bool contains;
                        int next;
                        do
                        {
                            next = r.Next((TheoreticalQuestions.Length));
                            contains = false;
                            for (int index = 0; index < i; index++)
                            {
                                int n = x[index];
                                if (n == next)
                                {
                                    contains = true;
                                    break;
                                }
                            }
                        } while (contains);
                        x[i] = next;
                    }

                    //заполняем массив  SequenceTheoreticalQuestions, 
                    //элементами ранее заполненного массива x[i],

                    while (step < SequenceTheoreticalQuestions.Length)
                    {
                        if (q > x.Length - 1)
                        {
                            q = 0;
                            break;
                        }
                        SequenceTheoreticalQuestions[step] = x[q];
                        q = q + 1;
                        step = step + 1;
                    }
                }
            }
        }

        public int[] SequencePracticalQuestions;
        public void CreateSequencePracticalQuestions()
        {
            int[] y = new int[PracticalQuestions.Length];

            int step = 0;
            int q = 0;

            double w = (QuantityOfTickets * QuantityOfPracticalQuestions) / Convert.ToDouble(PracticalQuestions.Length);

            int k = Convert.ToInt32(Math.Ceiling(w));


            //SequencePracticalQuestions Последовательность практических вопросов

            SequencePracticalQuestions = new int[QuantityOfTickets * QuantityOfPracticalQuestions];

            for (int j = 0; j < k; j++)
            {

                for (int i = 0; i < PracticalQuestions.Length; i++)
                {
                    bool contains;
                    int next;
                    do
                    {
                        next = r.Next((PracticalQuestions.Length));
                        contains = false;
                        for (int index = 0; index < i; index++)
                        {
                            int n = y[index];
                            if (n == next)
                            {
                                contains = true;
                                break;
                            }
                        }
                    } while (contains);
                    y[i] = next;
                }

                while (step < SequencePracticalQuestions.Length)
                {
                    if (q > y.Length - 1)
                    {
                        q = 0;
                        break;
                    }
                    SequencePracticalQuestions[step] = y[q];
                    q = q + 1;
                    step = step + 1;
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //проверка на введеное кол билетов и кол вопросов

            if (textBox1.Text == null)
            {
                MessageBox.Show("Не указано количество билетов");

            }

            else if ((QuantityOfPracticalQuestions == 0) || (QuantityOfTheoreticalQuestions == 0))
            {
                MessageBox.Show("Не указано количество практических и теоретических вопросов");
                return;
            }
            else
            {

                Object PathObj = pathToTemplate;
                object missingObj = System.Reflection.Missing.Value;
                Object trueObj = true;
                Object falseObj = false;
                string newLine = "\r";
                string blok;// tmp;
                /// блок переменных для вставки разрыва страницы и перехода на 
                /// следующую страницу

                object unit;
                object extend;
                unit = Microsoft.Office.Interop.Word.WdUnits.wdStory;
                extend = Microsoft.Office.Interop.Word.WdMovementType.wdMove;
                object oType;
                oType = Microsoft.Office.Interop.Word.WdBreakType.wdSectionBreakNextPage;


                //-------------------------------------------------

                int indexTerVopr = 0, indexPrVopr = 0;

                //путь для сохранения
                SaveFileDialog saveFile = new SaveFileDialog();
                saveFile.Filter = "doc|*.doc";

                if (saveFile.ShowDialog() == DialogResult.OK)
                {
                    //---------------------------------------------

                    //-------------------------------------------
                    //Объявляем и создаем объект Winword, это равносильно равносильно запуску Word

                    Microsoft.Office.Interop.Word.Application winword = new Microsoft.Office.Interop.Word.Application();
                    // Открываем файл, шаблон экзаменационных билетов
                    Microsoft.Office.Interop.Word.Document document = winword.Documents.Open(PathObj);

                    // Параметр замены указывает что необходимо заменить весь найденный текст 
                    object replaceAll = Microsoft.Office.Interop.Word.WdReplace.wdReplaceAll;

                    //объект поиска
                    Microsoft.Office.Interop.Word.Find findObj = document.Application.Selection.Find;

                    //копируем весь шаблон в буффер

                    Object begin = Type.Missing;
                    Object end1 = Type.Missing;
                    Object start, stop;
                    Microsoft.Office.Interop.Word.Range renge = document.Range(ref begin, ref end1);

                    renge.Select();
                    renge.Copy();


                    ///поиск и выдача сообщения об отсутствующих в документе метках
                    ///


                    /// формируем массив меток для замены одной метки "вопросы" на последовательность меток
                    /// т.е. для каждого вопроса будет свое место в тексте на которое указываем метка
                    string[] Q = new string[QuantityOfTheoreticalQuestions + QuantityOfPracticalQuestions];

                    int jp = 0;
                    int ip = 0;
                    for (ip = 0; ip < QuantityOfTheoreticalQuestions; ip++)
                    {
                        Q[ip] = "#q" + ip;
                    }

                    for (jp = 0; jp < QuantityOfPracticalQuestions; jp++)
                    {
                        Q[jp + ip] = "#q" + (jp + ip);
                    }


                    //генерируем случайную последовательность чисел для блока вопровов
                    CreateSequenceTheoreticalQuestions();
                    CreateSequencePracticalQuestions();


                    //count - номер билета

                    //-----------------------------------
                    int number = 1;
                    int numberBilet = 1;

                    //генерация билетов
                    for (int count = 1; count <= QuantityOfTickets; count++)
                    {
                        ///Поиск и замена меток на заданный текст,
                        ///текст замены и метка хранятся в DataGridView

                        string tag;
                        string pastText;

                        for (int i = 0; i < Convert.ToInt32(Convert.ToString(this.dataGridView1.RowCount.ToString())) - 1; i++)
                        {
                            tag = Convert.ToString(this.dataGridView1.Rows[i].Cells[0].Value);
                            pastText = Convert.ToString(this.dataGridView1.Rows[i].Cells[1].Value);

                            if (!tag.Equals(pastText))
                            {
                                findObj.ClearFormatting();
                                findObj.Text = tag;
                                findObj.Replacement.ClearFormatting();
                                findObj.Replacement.Text = pastText;

                                findObj.Execute(ref missingObj, ref missingObj, ref missingObj, ref missingObj, ref missingObj,
                                     ref missingObj, ref missingObj, ref missingObj, ref missingObj, ref missingObj,
                                      ref replaceAll, ref missingObj, ref missingObj, ref missingObj, ref missingObj);
                            }


                            {
                                //Находим метку "номер билета" и заменяем
                                // ее на порядковый номер билета

                                findObj.ClearFormatting();
                                findObj.Text = TagOfNumberTickets.Text;
                                findObj.Replacement.ClearFormatting();
                                findObj.Replacement.Text = Convert.ToString(count);

                                findObj.Execute(ref missingObj, ref missingObj, ref missingObj, ref missingObj, ref missingObj,
                            ref missingObj, ref missingObj, ref missingObj, ref missingObj, ref missingObj,
                            ref replaceAll, ref missingObj, ref missingObj, ref missingObj, ref missingObj);


                                numberBilet += 1;
                            }
                        }

                        /// 
                        //формируем блок замены метки "вопросы"
                        blok = null;
                        number = 1;
                        for (int c = 0; c < (QuantityOfPracticalQuestions + QuantityOfTheoreticalQuestions); c++)
                        {
                            blok = blok + Convert.ToString(number) + "." + Q[c] + newLine;
                            number++;
                        }

                        //ищем и заменяем поле #question1 на ранее сформированный блок меток
                        findObj.ClearFormatting();
                        // findObj.Text = "#question1";
                        findObj.Text = TagOfBlokQuestions.Text;
                        findObj.Replacement.ClearFormatting();
                        findObj.Replacement.Text = blok;

                        findObj.Execute(ref missingObj, ref missingObj, ref missingObj, ref missingObj, ref missingObj,
                    ref missingObj, ref missingObj, ref missingObj, ref missingObj, ref missingObj,
                    ref replaceAll, ref missingObj, ref missingObj, ref missingObj, ref missingObj);

                        /// ищем метку  и заменяем его вопросом.

                        for (temp = 0; temp < (QuantityOfTheoreticalQuestions + QuantityOfPracticalQuestions); temp++)
                        {
                            if (temp < QuantityOfTheoreticalQuestions)
                            {
                                findObj.ClearFormatting();
                                findObj.Text = Q[temp];
                                findObj.Replacement.ClearFormatting();
                                findObj.Replacement.Text = TheoreticalQuestions[SequenceTheoreticalQuestions[indexTerVopr]];
                                indexTerVopr++;
                            }

                            else
                            {
                                findObj.ClearFormatting();
                                findObj.Text = Q[temp];
                                findObj.Replacement.ClearFormatting();
                                findObj.Replacement.Text = PracticalQuestions[SequencePracticalQuestions[indexPrVopr]];
                                indexPrVopr++;
                            }

                            findObj.Execute(ref missingObj, ref missingObj, ref missingObj, ref missingObj, ref missingObj,
                                ref missingObj, ref missingObj, ref missingObj, ref missingObj, ref missingObj,
                                ref replaceAll, ref missingObj, ref missingObj, ref missingObj, ref missingObj);
                        }


                        if ((QuantityOfTickets - count) == 0)
                        {
                            break;
                        }
                        else
                        {
                            //перемещаем курсор в конец документа
                            winword.Selection.EndKey(ref unit, ref extend);
                            //вставляем разрыв страницы(курсор при этом окажется на 
                            //вначале 1 строки новой страницы
                            winword.Selection.InsertBreak(ref oType);

                            //вставляем ранее скопированный шаблон из буффера обмена

                            stop = document.Content.End;
                            start = document.Content.End - 1;
                            renge = document.Range(ref start, ref stop);
                            renge.Select();
                            renge.Paste();
                        }
                    }

                    //сохраняем файл

                    Object pathToSaveObj = saveFile.FileName;
                    document.SaveAs(ref pathToSaveObj, Microsoft.Office.Interop.Word.WdSaveFormat.wdFormatDocument,
                        ref missingObj, ref missingObj, ref missingObj, ref missingObj, ref missingObj, ref missingObj,
                        ref missingObj, ref missingObj, ref missingObj, ref missingObj, ref missingObj, ref missingObj,
                        ref missingObj, ref missingObj);
                    object doNotSaveChanges = Microsoft.Office.Interop.Word.WdSaveOptions.wdDoNotSaveChanges;
                    document.Close(ref doNotSaveChanges, ref missingObj, ref missingObj);

                    // убираем мусор
                    winword.Application.Quit(ref missingObj, ref missingObj, ref missingObj);
                    //   winword.Visible = true;
                }
            }

            MessageBox.Show("Билеты сформированы!");
        }



        private void button2_Click(object sender, EventArgs e)
        {
            System.IO.Stream myStr = null;
            OpenFileDialog OpenTags = new OpenFileDialog();
            OpenTags.Filter = "All file (*.*) | *.*| Text file |*.txt";
            OpenTags.FilterIndex = 2;
            if (OpenTags.ShowDialog() == DialogResult.OK)
            {
                if ((myStr = OpenTags.OpenFile()) != null)
                {
                    StreamReader myRead = new StreamReader(myStr, System.Text.Encoding.Default);
                    string[] str;

                    int num = 0;
                    try
                    {

                        string[] str1 = myRead.ReadToEnd().Split('\n');
                        num = str1.Count();
                        dataGridView1.RowCount = num;


                        for (int i = 0; i < num; i++)
                        {
                            if (i == 0)
                            {
                                str = str1[i].Split(':');
                                TagOfBlokQuestions.Text = str[0];
                                TagOfNumberTickets.Text = str[1];
                            }
                            else
                            {

                                str = str1[i].Split(':');
                                for (int j = 0; j < dataGridView1.ColumnCount; j++)
                                {
                                    try
                                    {
                                        dataGridView1.Rows[i - 1].Cells[j].Value = str[j];
                                    }
                                    catch (Exception ex)
                                    {
                                        MessageBox.Show(ex.Message);
                                    }
                                }
                            }


                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        myRead.Close();
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.IO.Stream myStream;
            SaveFileDialog saveTags = new SaveFileDialog();
            saveTags.Filter = "All file (*.*) | *.*| Text file |*.txt";
            saveTags.FilterIndex = 2;
            if (saveTags.ShowDialog() == DialogResult.OK)
            {
                if ((myStream = saveTags.OpenFile()) != null)
                {
                    StreamWriter myWriter = new StreamWriter(myStream, System.Text.Encoding.Default);
                    try
                    {
                        myWriter.Write(TagOfBlokQuestions.Text);
                        myWriter.Write(":");
                        myWriter.WriteLine(TagOfNumberTickets.Text);
                        for (int i = 0; i < dataGridView1.RowCount - 1; i++)
                        {
                            for (int j = 0; j < dataGridView1.ColumnCount; j++)
                            {
                                myWriter.Write(dataGridView1.Rows[i].Cells[j].Value.ToString());
                                if ((dataGridView1.ColumnCount - j) != 1) myWriter.Write(":");
                            }

                            if (((dataGridView1.RowCount - 1) - i - 1) != 0) myWriter.WriteLine();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        myWriter.Close();
                    }
                }
                myStream.Close();
            }
        }


    }
}
