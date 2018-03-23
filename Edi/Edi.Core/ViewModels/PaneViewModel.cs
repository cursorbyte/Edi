﻿using System;
using Edi.Core.ViewModels.Base;

namespace Edi.Core.ViewModels
{
	/// <summary>
	/// AvalonDock base class viewm-model to support document pane views
	/// </summary>
	public class PaneViewModel : ViewModelBase
	{
		#region Title

		private string _title;
		public virtual string Title
		{
			get => _title;
			set
			{
				if (_title != value)
				{
					_title = value;
					RaisePropertyChanged("Title");
				}
			}
		}
		#endregion

		public virtual Uri IconSource
		{
			get;

			protected set;
		}

		#region ContentId

		private string _contentId;
		public string ContentId
		{
			get => _contentId;
			set
			{
				if (_contentId != value)
				{
					_contentId = value;
					RaisePropertyChanged("ContentId");
				}
			}
		}
		#endregion

		#region IsSelected

		private bool _isSelected;
		public bool IsSelected
		{
			get => _isSelected;
			set
			{
				if (_isSelected != value)
				{
					_isSelected = value;
					RaisePropertyChanged("IsSelected");
				}
			}
		}

		#endregion

		#region IsActive

		private bool _isActive;
		public bool IsActive
		{
			get => _isActive;
			set
			{
				if (_isActive != value)
				{
					_isActive = value;
					RaisePropertyChanged("IsActive");
				}
			}
		}

		#endregion
	}
}
