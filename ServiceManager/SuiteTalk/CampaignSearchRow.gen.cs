﻿//~ Generated by SearchRowTemplate.tt
#if !FIRSTBUILD

#pragma warning disable 1591
using System;

namespace com.celigo.net.ServiceManager.SuiteTalk
{
	public partial class CampaignSearchRow : ISearchRow
	{
		/// <summary>Gets the Search Row Basic value.</summary>
		/// <returns>The ISearchRowBasic assigned to this row.</returns>
		public ISearchRowBasic GetSearchRowBasic()
		{
			return this.basic;
		}

		/// <summary>
		/// Sets the Search Row Basic value.
		/// </summary>
		/// <param name="basic">The ISearchRowBasic to be assigned to this row.</param>
		public void SetSearchRowBasic(ISearchRowBasic basic)
		{
			if (basic is CampaignSearchRowBasic)
				this.basic = (CampaignSearchRowBasic)basic;
			else
				throw new ArgumentException("Value should be of type CampaignSearchRowBasic", "basic");
		}
	}
}
	
#endif