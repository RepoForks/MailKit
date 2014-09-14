﻿//
// AuthenticationException.cs
//
// Author: Jeffrey Stedfast <jeff@xamarin.com>
//
// Copyright (c) 2014 Xamarin Inc. (www.xamarin.com)
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.
//

using System;
#if !NETFX_CORE
using System.Runtime.Serialization;
#endif

namespace MailKit.Security {
	/// <summary>
	/// The exception that is thrown when there is an authentication error.
	/// </summary>
	/// <remarks>
	/// The exception that is thrown when there is an authentication error.
	/// </remarks>
#if !NETFX_CORE
	[Serializable]
#endif
	public class AuthenticationException : Exception
	{
#if !NETFX_CORE
		/// <summary>
		/// Initializes a new instance of the <see cref="AuthenticationException"/> class.
		/// </summary>
		/// <remarks>
		/// Creates a new <see cref="AuthenticationException"/> from the seriaized data.
		/// </remarks>
		/// <param name="info">The serialization info.</param>
		/// <param name="context">The streaming context.</param>
		protected AuthenticationException (SerializationInfo info, StreamingContext context) : base (info, context)
		{
		}
#endif

		/// <summary>
		/// Initializes a new instance of the <see cref="AuthenticationException"/> class.
		/// </summary>
		/// <remarks>
		/// Creates a new <see cref="AuthenticationException"/>.
		/// </remarks>
		/// <param name="message">The error message.</param>
		/// <param name="innerException">An inner exception.</param>
		public AuthenticationException (string message, Exception innerException) : base (message, innerException)
		{
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="AuthenticationException"/> class.
		/// </summary>
		/// <remarks>
		/// Creates a new <see cref="AuthenticationException"/>.
		/// </remarks>
		/// <param name="message">The error message.</param>
		public AuthenticationException (string message) : base (message)
		{
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="AuthenticationException"/> class.
		/// </summary>
		/// <remarks>
		/// Creates a new <see cref="AuthenticationException"/>.
		/// </remarks>
		public AuthenticationException () : base ("Authentication failed.")
		{
		}
	}
}