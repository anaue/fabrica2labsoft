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

        /// <summary>
        /// Insere manutencao de um determinado patrimonio (OK).
        /// </summary>
        public void InsereManutencao(Manutencao manutencao)
        {
            ArvDatabase db = new ArvDatabase(_connString);
            try
            {
                List<SqlParameter> parameters = new List<SqlParameter>();

                parameters.Add(new SqlParameter("@RetSt", SqlDbType.Int));
                parameters.Add(new SqlParameter("@DtManutencao", manutencao.DtManutencao));
                parameters.Add(new SqlParameter("@MotivoManutencao", manutencao.Motivo));
                parameters.Add(new SqlParameter("@Observacoes", manutencao.Observacao));
                parameters.Add(new SqlParameter("@IdUsuario", manutencao.IdUsuario));
                parameters.Add(new SqlParameter("@IdPatrimonio", manutencao.IdPatrimonio));

                parameters[0].Direction = ParameterDirection.Output;


                db.AbreConexao();

                db.ExecuteTextNonQuery("sp_manutencao_inserir", parameters);
            }
            catch (Exception ex)
            {
                throw new ApplicationException("DAOPatrimonio.InsereManutencao(): " + ex, ex);
            }
            finally
            {
                db.FechaConexao();
            }
        }

        /// <summary>
        /// Insere um patrimonio apenas com atributos genericos (OK).
        /// </summary>
        internal void InserePatrimonio(Patrimonio patrimonio)
        {
            ArvDatabase db = new ArvDatabase(_connString);
            try
            {
                List<SqlParameter> parameters = new List<SqlParameter>();

                parameters.Add(new SqlParameter("@RetSt", SqlDbType.Int));
                parameters.Add(new SqlParameter("@DtCompra", patrimonio.DtCompra));
                parameters.Add(new SqlParameter("@NumeroNotaFiscal", patrimonio.NumeroNotaFiscal));
                parameters.Add(new SqlParameter("@DtExpGarantia", patrimonio.DtExpGarantia));
                parameters.Add(new SqlParameter("@IdTipoPatrimonio", patrimonio.IdTipoPatrimonio));
                parameters.Add(new SqlParameter("@CaminhoFotoNotaFiscal", patrimonio.CaminhoFotoNotaFiscal));
                parameters.Add(new SqlParameter("@CaminhoFotoPatrimonio", patrimonio.CaminhoFotoPatrimonio));
                parameters.Add(new SqlParameter("@NumeroPece", patrimonio.NumeroPECE));
                parameters.Add(new SqlParameter("@NumeroPedido", patrimonio.NumeroPedido));
                parameters.Add(new SqlParameter("@Local", patrimonio.LocalPatrimonio));

                parameters[0].Direction = ParameterDirection.Output;


                db.AbreConexao();

                db.ExecuteTextNonQuery("sp_patrimonio_inserir", parameters);
            }
            catch (Exception ex)
            {
                throw new ApplicationException("DAOPatrimonio.InserePatrimonio(): " + ex, ex);
            }
            finally
            {
                db.FechaConexao();
            }
        }

        /// <summary>
        /// Realiza baixa de um determinado patrimonio (OK).
        /// </summary>
        internal void ExecutaBaixaPatrimonio(Patrimonio patrimonio, Baixa baixa)
        {
            ArvDatabase db = new ArvDatabase(_connString);
            try
            {
                List<SqlParameter> parameters = new List<SqlParameter>();

                parameters.Add(new SqlParameter("@RetSt", SqlDbType.Int));
                parameters.Add(new SqlParameter("@DestinoBaixa", baixa.DestinoBaixa));
                parameters.Add(new SqlParameter("@DtBaixa", baixa.DtBaixa));
                parameters.Add(new SqlParameter("@ObservacoesBaixa", baixa.ObservacoesBaixa));
                parameters.Add(new SqlParameter("@IdUsuario", baixa.IdUsuario));
                parameters.Add(new SqlParameter("@IdPatrimonio", patrimonio.IdEquipamento));

                parameters[0].Direction = ParameterDirection.Output;

                db.AbreConexao();

                db.ExecuteTextNonQuery("sp_baixa_inserir", parameters);
            }
            catch (Exception ex)
            {
                throw new ApplicationException("DAOPatrimonio.ExecutaBaixaPatrimonio(): " + ex, ex);
            }
            finally
            {
                db.FechaConexao();
            }
        }

        /// <summary>
        /// Remove um patrimonio (OK).
        /// </summary>
        internal void DeletaPatrimonio(Patrimonio patrimonio)
        {
            ArvDatabase db = new ArvDatabase(_connString);
            try
            {
                List<SqlParameter> parameters = new List<SqlParameter>();

                parameters.Add(new SqlParameter("@RetSt", SqlDbType.Int));
                parameters.Add(new SqlParameter("@IdPatrimonio", patrimonio.IdEquipamento));

                parameters[0].Direction = ParameterDirection.Output;

                db.AbreConexao();

                db.ExecuteTextNonQuery("sp_patrimonio_remover", parameters);
            }
            catch (Exception ex)
            {
                throw new ApplicationException("DAOPatrimonio.DeletaPatrimonio(): " + ex, ex);
            }
            finally
            {
                db.FechaConexao();
            }
        }

        /// <summary>
        /// Atualiza valores de um patrimonio (apenas atributos genericos) (OK)
        /// </summary>
        internal void AlteraPatrimonio(Patrimonio patrimonio)
        {
            ArvDatabase db = new ArvDatabase(_connString);
            try
            {
                List<SqlParameter> parameters = new List<SqlParameter>();

                parameters.Add(new SqlParameter("@RetSt", SqlDbType.Int));
                parameters.Add(new SqlParameter("@IdPatrimonio", patrimonio.IdEquipamento));
                parameters.Add(new SqlParameter("@DtCompra", patrimonio.DtCompra));
                parameters.Add(new SqlParameter("@NumeroNotaFiscal", patrimonio.NumeroNotaFiscal));
                parameters.Add(new SqlParameter("@DtExpGarantia", patrimonio.DtExpGarantia));
                parameters.Add(new SqlParameter("@IdTipoPatrimonio", patrimonio.IdTipoPatrimonio));
                parameters.Add(new SqlParameter("@CaminhoFotoNotaFiscal", patrimonio.CaminhoFotoNotaFiscal));
                parameters.Add(new SqlParameter("@CaminhoFotoPatrimonio", patrimonio.CaminhoFotoPatrimonio));
                parameters.Add(new SqlParameter("@NumeroPece", patrimonio.NumeroPECE));
                parameters.Add(new SqlParameter("@NumeroPedido", patrimonio.NumeroPedido));
                parameters.Add(new SqlParameter("@Local", patrimonio.LocalPatrimonio));

                parameters[0].Direction = ParameterDirection.Output;


                db.AbreConexao();

                db.ExecuteTextNonQuery("sp_patrimonio_alterar", parameters);
            }
            catch (Exception ex)
            {
                throw new ApplicationException("DAOPatrimonio.AlteraPatrimonio(): " + ex, ex);
            }
            finally
            {
                db.FechaConexao();
            }
        }

        /// <summary>
        /// Faz uma busca por todos os patrimonios pelos parametros opcionais não nulos.
        /// </summary>
        internal List<Patrimonio> ObterPatrimonios(int idEquipamento, DateTime dtCompraMin, DateTime dtCompraMax,
            int numeroNotaFiscal, DateTime dtExpGarantiaMin, DateTime dtExpGarantiaMax, int idTipoPatrimonio,
            string caminhoFotoNotaFiscal, string caminhoFotoPatrimonio, int numeroPece, string numeroPedido, string local)
        {
            ArvDatabase db = new ArvDatabase(_connString);
            try
            {
                List<Patrimonio> lstPatrimonio = new List<Patrimonio>();
                SqlDataReader objLeitor;
                List<SqlParameter> parameters = new List<SqlParameter>();
                Patrimonio objPatrimonio;

                parameters.Add(new SqlParameter("@RetSt", SqlDbType.Int));

                if (idEquipamento != null)
                    parameters.Add(new SqlParameter("@IdPatrimonio", idEquipamento));

                if (dtCompraMin != null)
                    parameters.Add(new SqlParameter("@DtCompra_Min", dtCompraMin));

                if (dtCompraMax != null)
                    parameters.Add(new SqlParameter("@DtCompra_Max", dtCompraMax));

                if (numeroNotaFiscal!= null)
                    parameters.Add(new SqlParameter("@NumeroNotaFiscal", numeroNotaFiscal));

                if (dtExpGarantiaMin != null)
                    parameters.Add(new SqlParameter("@DtExpGarantia_Min", dtExpGarantiaMin));

                if (dtExpGarantiaMax != null)
                    parameters.Add(new SqlParameter("@DtExpGarantia_Max", dtExpGarantiaMax));

                if (idTipoPatrimonio != null)
                    parameters.Add(new SqlParameter("@IdTipoPatrimonio", idTipoPatrimonio));

                if (caminhoFotoNotaFiscal != null && caminhoFotoNotaFiscal != "")
                    parameters.Add(new SqlParameter("@CaminhoFotoNotaFiscal", caminhoFotoNotaFiscal));

                if (caminhoFotoPatrimonio != null && caminhoFotoPatrimonio != "")
                    parameters.Add(new SqlParameter("@CaminhoFotoPatrimonio", caminhoFotoPatrimonio));

                if (numeroPece != null)
                    parameters.Add(new SqlParameter("@NumeroPece", numeroPece));

                if (numeroPedido != null && numeroPedido != "")
                    parameters.Add(new SqlParameter("@NumeroPedido", numeroPedido));

                if (local != null && local != "")
                    parameters.Add(new SqlParameter("@Local", local));


                parameters[0].Direction = ParameterDirection.Output;


                db.AbreConexao();

                objLeitor = db.ExecuteProcedureReader("sp_patrimonio_consultar", parameters);

                while (objLeitor.Read())
                {
                    objPatrimonio = new Patrimonio();

                    if (objLeitor["IdPatrimonio"] != null)
                        objPatrimonio.IdEquipamento = (int)objLeitor["IdPatrimonio"];

                    if (objLeitor["DtCompra"] != null)
                        objPatrimonio.DtCompra = (DateTime)objLeitor["DtCompra"];

                    if (objLeitor["NumeroNotaFiscal"] != null)
                        objPatrimonio.NumeroNotaFiscal = (int)objLeitor["NumeroNotaFiscal"];

                    if (objLeitor["DtExpGarantia"] != null)
                        objPatrimonio.DtExpGarantia = (DateTime)objLeitor["DtExpGarantia"];

                    if (objLeitor["IdTipoPatrimonio"] != null)
                        objPatrimonio.IdTipoPatrimonio = (int)objLeitor["IdTipoPatrimonio"];

                    if (objLeitor["CaminhoFotoNotaFiscal"] != null)
                        objPatrimonio.CaminhoFotoNotaFiscal = objLeitor["CaminhoFotoNotaFiscal"].ToString();

                    if (objLeitor["CaminhoFotoPatrimonio"] != null)
                        objPatrimonio.CaminhoFotoPatrimonio = objLeitor["CaminhoFotoPatrimonio"].ToString();

                    if (objLeitor["NumeroPece"] != null)
                        objPatrimonio.NumeroPECE = (int)objLeitor["NumeroPece"];

                    if (objLeitor["NumeroPedido"] != null)
                        objPatrimonio.NumeroPedido = objLeitor["NumeroPedido"].ToString();

                    if (objLeitor["Local"] != null)
                        objPatrimonio.LocalPatrimonio = objLeitor["Local"].ToString();

                    lstPatrimonio.Add(objPatrimonio);
                }

                objLeitor.Close();
                objLeitor.Dispose();

                return lstPatrimonio;
            }
            catch (Exception ex)
            {
                throw new ApplicationException("DAOPatrimonio.ObterPatrimonios(): " + ex, ex);
            }
            finally
            {
                db.FechaConexao();
            }
        }

        /// <summary>
        /// Consulta um determinado patrimonio (apenas atributos genericos) (OK).
        /// </summary>
        internal Patrimonio ConsultaPatrimonio(int idPatrimonio)
        {
            ArvDatabase db = new ArvDatabase(_connString);
            try
            {
                SqlDataReader objLeitor;
                List<SqlParameter> parameters = new List<SqlParameter>();
                Patrimonio objPatrimonio = new Patrimonio();

                parameters.Add(new SqlParameter("@RetSt", SqlDbType.Int));
                parameters.Add(new SqlParameter("@IdPatrimonio", idPatrimonio));

                parameters[0].Direction = ParameterDirection.Output;


                db.AbreConexao();

                objLeitor = db.ExecuteProcedureReader("sp_patrimonio_consultar", parameters);

                while (objLeitor.Read())
                {
                    objPatrimonio = new Patrimonio();

                    if (objLeitor["IdPatrimonio"] != null)
                        objPatrimonio.IdEquipamento = (int)objLeitor["IdPatrimonio"];

                    if (objLeitor["DtCompra"] != null)
                        objPatrimonio.DtCompra = (DateTime)objLeitor["DtCompra"];

                    if (objLeitor["NumeroNotaFiscal"] != null)
                        objPatrimonio.NumeroNotaFiscal = (int)objLeitor["NumeroNotaFiscal"];

                    if (objLeitor["DtExpGarantia"] != null)
                        objPatrimonio.DtExpGarantia = (DateTime)objLeitor["DtExpGarantia"];

                    if (objLeitor["IdTipoPatrimonio"] != null)
                        objPatrimonio.IdTipoPatrimonio = (int)objLeitor["IdTipoPatrimonio"];

                    if (objLeitor["CaminhoFotoNotaFiscal"] != null)
                        objPatrimonio.CaminhoFotoNotaFiscal = objLeitor["CaminhoFotoNotaFiscal"].ToString();

                    if (objLeitor["CaminhoFotoPatrimonio"] != null)
                        objPatrimonio.CaminhoFotoPatrimonio = objLeitor["CaminhoFotoPatrimonio"].ToString();

                    if (objLeitor["NumeroPece"] != null)
                        objPatrimonio.NumeroPECE = (int)objLeitor["NumeroPece"];

                    if (objLeitor["NumeroPedido"] != null)
                        objPatrimonio.NumeroPedido = objLeitor["NumeroPedido"].ToString();

                    if (objLeitor["Local"] != null)
                        objPatrimonio.LocalPatrimonio = objLeitor["Local"].ToString();

                }

                objLeitor.Close();
                objLeitor.Dispose();

                return objPatrimonio;
            }
            catch (Exception ex)
            {
                throw new ApplicationException("DAOPatrimonio.ConsultaPatrimonio(): " + ex, ex);
            }
            finally
            {
                db.FechaConexao();
            }
        }

        /// <summary>
        /// Busca todos os patrimonios de determinado tipo (apenas atributos genericos) (OK).
        /// </summary>
        internal List<Patrimonio> BuscaPatrimonioPeloIdTipoPatrimonio(int idTipoPatrimonio)
        {
            ArvDatabase db = new ArvDatabase(_connString);
            try
            {
                List<Patrimonio> lstPatrimonio = new List<Patrimonio>();
                SqlDataReader objLeitor;
                List<SqlParameter> parameters = new List<SqlParameter>();
                Patrimonio objPatrimonio;

                parameters.Add(new SqlParameter("@RetSt", SqlDbType.Int));
                parameters.Add(new SqlParameter("@IdTipoPatrimonio", idTipoPatrimonio));

                parameters[0].Direction = ParameterDirection.Output;


                db.AbreConexao();

                objLeitor = db.ExecuteProcedureReader("sp_patrimonio_consultar", parameters);

                while (objLeitor.Read())
                {
                    objPatrimonio = new Patrimonio();

                    if (objLeitor["IdPatrimonio"] != null)
                        objPatrimonio.IdEquipamento = (int)objLeitor["IdPatrimonio"];

                    if (objLeitor["DtCompra"] != null)
                        objPatrimonio.DtCompra = (DateTime)objLeitor["DtCompra"];

                    if (objLeitor["NumeroNotaFiscal"] != null)
                        objPatrimonio.NumeroNotaFiscal = (int)objLeitor["NumeroNotaFiscal"];

                    if (objLeitor["DtExpGarantia"] != null)
                        objPatrimonio.DtExpGarantia = (DateTime)objLeitor["DtExpGarantia"];

                    if (objLeitor["IdTipoPatrimonio"] != null)
                        objPatrimonio.IdTipoPatrimonio = (int)objLeitor["IdTipoPatrimonio"];

                    if (objLeitor["CaminhoFotoNotaFiscal"] != null)
                        objPatrimonio.CaminhoFotoNotaFiscal = objLeitor["CaminhoFotoNotaFiscal"].ToString();

                    if (objLeitor["CaminhoFotoPatrimonio"] != null)
                        objPatrimonio.CaminhoFotoPatrimonio = objLeitor["CaminhoFotoPatrimonio"].ToString();

                    if (objLeitor["NumeroPece"] != null)
                        objPatrimonio.NumeroPECE = (int)objLeitor["NumeroPece"];

                    if (objLeitor["NumeroPedido"] != null)
                        objPatrimonio.NumeroPedido = objLeitor["NumeroPedido"].ToString();

                    if (objLeitor["Local"] != null)
                        objPatrimonio.LocalPatrimonio = objLeitor["Local"].ToString();

                    lstPatrimonio.Add(objPatrimonio);
                }

                objLeitor.Close();
                objLeitor.Dispose();

                return lstPatrimonio;
            }
            catch (Exception ex)
            {
                throw new ApplicationException("DAOPatrimonio.BuscaPatrimonioPeloIdTipoPatrimonio(): " + ex, ex);
            }
            finally
            {
                db.FechaConexao();
            }
        }
    }
}
