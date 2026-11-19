using backUrbanPark.Model;
using backUrbanPark.Repository;

namespace backUrbanPark
{

    public class Program
    {

        static void Main(string[] args)
        {
            Banco.TestarConexao();



            //VagaRepository repository = new VagaRepository();

            //List<Vaga>  vagas = repository.ListarTodas();

            //foreach (Vaga vag in vagas)
            //{
            //    System.Console.WriteLine($"ID: {vag.Id} - \nTipo: {vag.TipoStatus} \n{vag.TipoVaga}");
            //}
           

        }
    }


}


