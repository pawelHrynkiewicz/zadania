using System.Text;

namespace _13_WindowsForms
{
    public partial class MainWidow : Form
    {
        private List<string> _cars = new();
        private readonly DataService _dataService;

        public MainWidow()
        {
            InitializeComponent();
            InitDataView();
            _dataService = new DataService();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var filePathWindow = new GetFilePathWindow(this);
            //filePathWindow.Show();
            filePathWindow.ShowDialog();
            var filePath = filePathWindow.FilePath;
            if (String.IsNullOrWhiteSpace(filePath))
            {
                return;
            }


        }

        public void LoadData(string filePath)
        {
            _cars = _dataService.GetCarsFromFile(filePath);
            //SetDataView(allLines.ToList());


        }

        private void MainWidow_Load(object sender, EventArgs e)
        {

        }
        private void InitDataView()
        {
            var cars = _dataService.GetCarsFromFile(null);
            SetDataView(cars);
        }
        private void SetDataView(List<Car> cars)
        {

            var dataView = Controls
            .Find("dataView", true)
            .FirstOrDefault()
            as DataGridView;
            foreach (var car in cars)
            {

                var newRowId = dataView.Rows.Add();
                var newRow = dataView.Rows[newRowId];

                newRow.Cells[0].Value = car.Name;
                newRow.Cells[1].Value = car.Model;
                newRow.Cells[2].Value = car.Year;

            }
        }
        private void MapLinesToCars(string[] stringCars)
        {
            var result = new List<Car>();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}