﻿using System.Data;

namespace Bargozideh.Framework.Repository.Mapper
{
    public interface IRowMapper<TResult>
    {
        /// <summary>
        /// When implemented by a class, returns a new <typeparamref name="TResult"/> based on <paramref name="row"/>.
        /// 
        /// </summary>
        /// <param name="row">The <see cref="T:System.Data.IDataRecord"/> to map.</param>
        /// <returns>
        /// The instance of <typeparamref name="TResult"/> that is based on <paramref name="row"/>.
        /// </returns>
        TResult MapRow(IDataRecord row);
    }
}
