using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
	public interface IRepository<T> where T : class
	{
		/// <summary>
		/// Este método retorna os dados como IEnumerable
		/// </summary>
		/// <returns></returns>
		IEnumerable<T> Get();
		
		/// <summary>
		/// Retorna os dados que atendem o critério informado em tempo de execução via expressão lambada. Estamos usando o delegate Func, e aplicando o predicate para verificar se o dado atende o critério (retorna true ou false)
		/// </summary>
		/// <param name="predicate"></param>
		/// <returns></returns>
		IEnumerable<T> Get(Expression<Func<T, bool>> predicate);
		
		T GetById(Expression<Func<T, bool>> predicate);
		/// <summary>
		/// Recebe o objeto T para realizar a inclusão no banco de dados
		/// </summary>
		/// <param name="entity"></param>
		void Add(T entity);

		/// <summary>
		/// Recebe o objeto T e realiza a exclusão no banco de dados
		/// </summary>
		/// <param name="entity"></param>
		void Delete(T entity);

		/// <summary>
		///  Recebe o objeto T para realizar a atualização no banco de dados
		/// </summary>
		/// <param name="entity"></param>
		void Update(T entity);
	}
}
