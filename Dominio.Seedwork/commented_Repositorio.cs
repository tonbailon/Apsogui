//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Dominio.Seedwork
//{
//    class Repositorio<TEntity> : IRepositorio<TEntity> where TEntity:class
//    {

//        private IRepositorio<TEntity> m_Repositorio;
//        public Repositorio()
//        {
//            //m_Repositorio = new RepositorioADO<TEntity>();
//            //m_Repositorio = new RepositorioDbContext<TEntity>();
//            //m_Repositorio = new RepositorioNHibernate<TEntity>();

//        }

//        public void Add(TEntity item)
//        {
//            m_Repositorio.Add(item);
//        }

//        public void Dispose()
//        {
//            m_Repositorio.Dispose();
//        }

//        public TEntity Get(string Id)
//        {
//            m_Repositorio.Get(Id);
//        }

//        public IEnumerable<TEntity> GetAll()
//        {
//            m_Repositorio.GetAll();
//        }

//        public void Remove(TEntity item)
//        {
//            m_Repositorio.Remove(item);
//        }
//    }
//}
