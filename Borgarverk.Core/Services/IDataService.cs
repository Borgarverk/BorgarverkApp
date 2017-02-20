using System;
using System.Collections.Generic;

namespace Borgarverk.Core.Services
{
	public interface IDataService
	{
		List<FormEntry> FormsMatching(string nameFilter);
		void Insert(FormEntry formEntry);
		void Update(FormEntry formEntry);
		void Delete(FormEntry formEntry);
		int Count { get; }
	}
}