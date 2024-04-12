using Microsoft.Data.SqlClient;
using StoreManager.DTO;
using StoreManager.Repository;
using StoreManager.Service.Interfaces.Repositories;

namespace StoreManager.App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = "Server = .; Database = StoreManager.Database; Integrated Security = SSPI; TrustServerCertificate = true";

            IUnitOfWork<SqlConnection> unitOfWork = new UnitOfWork<SqlConnection>(connectionString);
            unitOfWork.GetConnection();
            unitOfWork.BeginTransaction();
            unitOfWork.Dispose();


            //CategoryRepository repository = new(connectionString);

            //Category category = repository.Get(1);

            //var name = category.Name;

            //Category category1 = new() { CategoryId = 2, Name = "MyCategory", Description = "Description" };

            //repository.Update(category1);

            Console.ReadLine();
        }
    }
}
