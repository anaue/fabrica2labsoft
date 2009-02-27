using System;
using System.Data;
using System.Data.SqlClient;
using Arv.Database;
using System.Collections.Generic;

namespace Patrimonio.Patrimonio
{
    public class DAOPatrimonio
    {
        public DAOPatrimonio()
        {
            _connString = Properties.Settings.Default.ConnectionString;
        }
         private string _connString;

         public int InsereManutencao(Manutencao manutencao)
         {
             int linhasafetadas = 0;
             int idGerado = 0;
             ArvDatabase db = new ArvDatabase(_connString);
             try
             {

                 List<SqlParameter> parameters = new List<SqlParameter>();
                 //parameters.Add(new SqlParameter("@nome", atributo.Nome));
                 //parameters.Add(new SqlParameter("@tipo", atributo.Tipo));
                 //parameters.Add(new SqlParameter("@descricao" , atributo.Descricao));
                 //parameters.Add(new SqlParameter("@nulo", atributo.Nulo));

                 db.AbreConexao();
                 //linhasafetadas = db.ExecuteTextNonQuery(" INSERT INTO tb_Atributo (nomeAtributo, descAtributo, tipoAtributo, nuloAtributo) VALUES( @nome, @descricao, @tipo, @nulo)", parameters);

                 //idGerado = Int32.Parse(db.ExecuteScalar(" SELECT SCOPE_IDENTITY() AS ID").ToString());

             }
             catch (Exception ex)
             {
                 throw ex;
             }
             finally
             {
                 db.FechaConexao();
             }
             if (linhasafetadas == 0) { return linhasafetadas; }
             else { return idGerado; }
         }


         internal int InserePatrimonio(Patrimonio patrimonio)
         {
             throw new NotImplementedException();
         }

         internal int ExecutaBaixaPatrimonio(Patrimonio patrimonio, Baixa baixa)
         {
             throw new NotImplementedException();
         }

         internal int DeletaPatrimonio(Patrimonio patrimonio)
         {
             throw new NotImplementedException();
         }

         internal bool AlteraPatrimonio(Patrimonio patrimonio)
         {
             throw new NotImplementedException();
         }

         internal List<Patrimonio> ObterPatrimonios(Patrimonio patrimonio)
         {
             throw new NotImplementedException();
         }



         public List<Patrimonio> BuscaPatrimonioPeloIdTipoPatrimonio(int idTipoPatrimonio)
         {
             //busca os patrimonios do tipo indicado pelo idTipoPatrimonio
             // Select * from PATRIMONIO where idIipoEquipamento = { idTipoPatrimonio }
             throw new NotImplementedException();
         }
    }
}
