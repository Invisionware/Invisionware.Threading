// ***********************************************************************
// Assembly         : Invisionware.Threading
// Author           : Shawn Anderson (sanderson@eye-catcher.com)
// Created          : 12-24-2015
//
// Last Modified By : Shawn Anderson (sanderson@eye-catcher.com)
// Last Modified On : 10-16-2016
// ***********************************************************************
// <copyright file="TaskLocal.cs" company="Personal">
//     Copyright (c) Personal. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.Security;
using System.Threading;

namespace Invisionware.Threading
{
	/// <summary>
	/// Class TaskLocal.
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// TODO Edit XML Comment Template for TaskLocal`1
	public class TaskLocal<T> : ITaskLocal<T>
	{
		/// <summary>
		/// The asynchronous local
		/// </summary>
		/// TODO Edit XML Comment Template for _asyncLocal
		private readonly AsyncLocal<T> _asyncLocal;

		/// <summary>
		/// Initializes a new instance of the <see cref="TaskLocal{T}"/> class.
		/// </summary>
		/// TODO Edit XML Comment Template for #ctor
		public TaskLocal() : this(default(T))
		{
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="TaskLocal{T}"/> class.
		/// </summary>
		/// <param name="defaultValue">The default value.</param>
		/// TODO Edit XML Comment Template for #ctor
		public TaskLocal(T defaultValue)
		{
		    _asyncLocal = new AsyncLocal<T> {Value = defaultValue};

		}

		/// <summary>
		/// Gets or sets the value.
		/// </summary>
		/// <value>The value.</value>
		/// TODO Edit XML Comment Template for Value
		public T Value
		{
			[SecuritySafeCritical]
			get { return _asyncLocal.Value; }
			[SecuritySafeCritical]
			set { _asyncLocal.Value = value; }
		}
	}
}

