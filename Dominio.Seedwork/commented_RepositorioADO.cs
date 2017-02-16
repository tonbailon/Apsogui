//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Dominio.Seedwork
//{
//    abstract class RepositorioADO
//    {
//        //TONI: ESTA CLASE TIENE QUE ESTAR DEFINIDA EN CADA BOUND CONTEXT, NO PUEDE SER GENÉRICA PORQUE
//        //DEPENDE DE LA TABLA CONCRETA QUE SE CONSULTA, QUE ESTÁ EN LA CADENA SQL.
//        //PARA LOS FRAMEWORKS PERSISTENTES SÍ, PORQUE EL TRATAMIENTO DE LAS ENTIDADES ES SIEMPRE IGUAL


//        //protected readonly ADOCONTEXT?? m_context;

//        public abstract TEntity Get(string Id);

//        public abstract IEnumerable<TEntity> GetAll();
//        public abstract void Remove(TEntity item);
//        public abstract void Add(TEntity item);
//        public abstract void Dispose();
        
//    }
//}
