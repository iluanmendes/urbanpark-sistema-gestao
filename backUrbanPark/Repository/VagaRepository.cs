using backUrbanPark.Model;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace backUrbanPark.Repository
{
    public class VagaRepository
    {

       
        /// <summary>
        /// Insere uma vaga no banco de dados
        /// </summary>
        /// <param name="vaga"></param>
        /// <returns></returns>
        public int Inserir(Vaga vaga)
        {
            return 1;
        }

        /// <summary>
        /// Busca uma vaga específica pelo ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Vaga? ListarPorId(int id) {
            string sql = "SELECT id_vaga, numero_vaga, tipo, status FROM vagas WHERE id = @id";

            using (var cmd = new MySqlCommand(sql))
            {
                cmd.Parameters.AddWithValue("@id", id);

                using (var reader = Banco.ExecutarConsulta(cmd)) {

                    if (reader.Read())
                    {
                        return MapearVaga(reader);
                    }
                
                }
            }
            return null;        
        }

        /// <summary>
        /// Retorna todas as vagas cadastradas
        /// </summary>
        /// <returns></returns>
        public List<Vaga> ListarTodas() {

            string sql = "SELECT id_vaga, numero_vaga, tipo, status FROM vagas";

            List<Vaga> vagas = new();

            using (var cmd = new MySqlCommand(sql))            {                

                using (var reader = Banco.ExecutarConsulta(cmd)) {

                    while (reader.Read()) {

                        vagas.Add(MapearVaga(reader));
                    }

                }
            }
            return vagas;
        }

        /// <summary>
        /// Método auxiliar para converter uma linha do MySqlDataReader em um objeto Vaga.
        /// </summary>
        /// <param name="reader"></param>
        /// <returns></returns>

        private Vaga MapearVaga(MySqlDataReader reader) {

            int id_vaga = reader.GetInt32("id_vaga");
            int numero_vaga = reader.GetInt32("numero_vaga");
            TipoVaga tipoVaga = Enum.Parse<TipoVaga>(reader.GetString("tipo"));
            TipoStatus tipoStatus = Enum.Parse<TipoStatus>(reader.GetString("status"));

            return new Vaga(id_vaga, numero_vaga, tipoVaga, tipoStatus);       
        }
    }
}
