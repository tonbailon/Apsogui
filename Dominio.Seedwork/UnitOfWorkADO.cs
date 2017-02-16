//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Dominio.Seedwork
//{
//TONI: NO SE PUEDE GENERAR UNA UNIDAD DE TRABAJO CON ADO PORQUE LA TRANSACCIÓN QUEDA ABIERTA DESDE 
//QUE SE INICIA LA UNIDAD DE TRABAJO HASTA QUE SE HACE EL COMMIT, PERDIENDO LA GRACIA DEL PATRÓN EN SÍ
//    public class UnitOfWorkADO: IUnitOfWork
//    {

//        private System.Data.IDbConnection m_conexion;        
//        private System.Data.IDbTransaction m_transaccion;

//        public UnitOfWorkADO()
//        {
//            var connection = new System.Data.SqlClient.SqlConnection("MyCadenaDeConexion");
//            connection.Open();
//            m_conexion = connection;            
//            m_transaccion = connection.BeginTransaction();
//        }

//        public System.Data.IDbCommand CreateCommand()
//        {
//            var command = m_conexion.CreateCommand();
//            command.Transaction = m_transaccion;
//            return command;
//        }

//        public void AceptarCambios()
//        {
//            if (m_transaccion == null)
//                throw new InvalidOperationException
//                 ("Transaction have already been committed. Check your transaction handling.");

//            m_transaccion.Commit();
//            m_transaccion = null;
//        }

//        public void Rollback()
//        {
//            if (m_transaccion != null)
//            {
//                m_transaccion.Rollback();
//                m_transaccion = null;
//            }

//            if (m_conexion != null)
//            {
//                m_conexion.Close();
//                m_conexion = null;
//            }
//        }

//    }

//}
