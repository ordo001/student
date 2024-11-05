using Exel = Microsoft.Office.Interop.Excel;
namespace student
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            UpdateSubjects();
            ImportStudent();
        }

        void UpdateSubjects()
        {
            using(StreamReader sr = new StreamReader("C:\\Users\\587-22\\source\\repos\\student\\student\\subjects.txt"))
            {
                while(!sr.EndOfStream)
                {
                    comboBox2.Items.Add(sr.ReadLine());
                }
            }
        }

        List<string> listStudent = new List<string>();

        void ImportStudent()
        {
            if (comboBox1.SelectedIndex == 0)
            {
                var book = new Exel.Application();
                var newBook = book.Workbooks.Open("C:\\Users\\587-22\\source\\repos\\student\\student\\IP-22-3.xlsx");
                var worksheet = book.Worksheets["Лист1"];
                int i = 1;
                string cellValue = worksheet.Cells[i, 1].Value;
                while (cellValue != null)
                {
                    //MessageBox.Show(cellValue, cellValue);
                    listStudent.Add(cellValue);
                    cellValue = worksheet.Cells[i, 1].Value;
                    i++;
                }
                UpdateDataGrid();
            }
            if (comboBox1.SelectedIndex == 1)
            {
                var book = new Exel.Application();
                var newBook = book.Workbooks.Open("C:\\Users\\587-22\\source\\repos\\student\\student\\IP-22-7k.xlsx");
                var worksheet = book.Worksheets["Лист1"];
                int i = 1;
                string cellValue = worksheet.Cells[i, 1].Value;
                while (cellValue != null)
                {
                    //MessageBox.Show(cellValue, cellValue);
                    listStudent.Add(cellValue);
                    cellValue = worksheet.Cells[i, 1].Value;
                    i++;
                }
                UpdateDataGrid();
            }
        }

        void UpdateDataGrid()
        {
            dataGridView1.Rows.Clear();
            for (int i = 0; i < listStudent.Count - 1; i++)
            {
                var cell = listStudent[i];
                dataGridView1.Rows.Add();
                dataGridView1.Rows[i].Cells[0].Value = cell;
            }
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listStudent.Clear();
            ImportStudent();
        }
    }
}
