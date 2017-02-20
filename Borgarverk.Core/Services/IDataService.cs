using System;
using System.Collections.Generic;

namespace Borgarverk.Core.Services
{
	public interface IDataService
	{
		List<FormEntry> FormsMatching(string nameFilter);
		void Insert(FormEntry kitten);
		void Update(FormEntry kitten);
		void Delete(FormEntry kitten);
		int Count { get; }
	}
}