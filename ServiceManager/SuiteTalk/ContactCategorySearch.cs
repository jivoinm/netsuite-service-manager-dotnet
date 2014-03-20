//~ Generated by SearchRecordTemplate.tt
#pragma warning disable 1591
using System;

namespace com.celigo.net.ServiceManager.SuiteTalk
{
	public partial class ContactCategorySearchBasic : ISearchBasic	
	{	}

	public partial class ContactCategorySearch : ISearchRecord
	{
		/// <summary>
		/// Gets the basic search criteria.
		/// </summary>
		/// <returns>The basic search criteria</returns>
		public ISearchBasic GetSearchBasic()
		{
			return this.basic;
		}
			
		/// <summary>
		/// Gets the basic search criteria.
		/// </summary>
		/// <param name="create">if set to <c>true</c> creates the basic criteria if null.</param>
		/// <returns>The basic search criteria</returns>
		public ISearchBasic GetSearchBasic(bool create)
		{
			if (create && this.basic == null)
				this.basic = new ContactCategorySearchBasic();
			return this.basic;
		}
	}
}	