using System;
using System.Collections.Generic;

namespace CSharp
{
	public static class Utilities
	{
		#region Compound

		public static T1 Compound<T1>(Func<T1, T1, T1> function, List<T1> arg1)
		{
			T1 result = default;

			if (arg1.Count == 0)
				return result;

			result = arg1[0];

			for (int i = 1; i < arg1.Count; i++)
			{
				result = function(result, arg1[i]);
			}

			return result;
		}

		public static T1 Compound<T1>(Func<T1, T1, T1> function, Func<T1, bool> shortCircuit, List<T1> arg1)
		{
			T1 result = default;

			if (arg1.Count == 0)
				return result;

			result = arg1[0];

			for (int i = 1; i < arg1.Count; i++)
			{
				result = function(result, arg1[i]);

				if (shortCircuit(result))
					break;
			}

			return result;
		}

		#endregion

		#region Mapcar
		#region Individually Typed

		/// <summary>
		/// Returns a list of <typeparamref name="TResult"/> elements that is the result of executing a function with a list(s) supplied as arguments to the function.
		/// </summary>
		/// <typeparam name="TResult"></typeparam>
		/// <typeparam name="T1"></typeparam>
		/// <param name="function">The executing function parameter</param>
		/// <param name="arg1">The list of 0 position parameter arguments to the executing function</param>
		/// <returns>A list of <typeparamref name="TResult"/> elements</returns>
		public static List<TResult> Mapcar<TResult, T1>(Func<T1, TResult> function,
			List<T1> arg1)
		{
			List<TResult> result = new List<TResult>();

			int count = arg1.Count;

			for (int i = 0; i < count; i++)
			{
				result.Add(function(arg1[i]));
			}

			return result;
		}

		/// <summary>
		/// Returns a list of <typeparamref name="TResult"/> elements that is the result of executing a function with a list(s) supplied as arguments to the function.
		/// </summary>
		/// <typeparam name="TResult"></typeparam>
		/// <typeparam name="T1"></typeparam>
		/// <typeparam name="T2"></typeparam>
		/// <param name="function">The executing function parameter</param>
		/// <param name="arg1">The list of 0 position parameter arguments to the executing function</param>
		/// <param name="arg2">The list of 1 position parameter arguments to the executing function</param>
		/// <returns></returns>
		public static List<TResult> Mapcar<TResult, T1, T2>(Func<T1, T2, TResult> function, 
			List<T1> arg1, List<T2> arg2)
		{
			List<TResult> result = new List<TResult>();

			int count = Math.Min(arg1.Count, arg2.Count);

			for (int i = 0; i < count; i++)
			{
				result.Add(function(arg1[i], arg2[i]));
			}

			return result;
		}

		/// <summary>
		/// Returns a list of <typeparamref name="TResult"/> elements that is the result of executing a function with a list(s) supplied as arguments to the function.
		/// </summary>
		/// <typeparam name="TResult"></typeparam>
		/// <typeparam name="T1"></typeparam>
		/// <typeparam name="T2"></typeparam>
		/// <typeparam name="T3"></typeparam>
		/// <param name="function">The executing function parameter</param>
		/// <param name="arg1">The list of 0 position parameter arguments to the executing function</param>
		/// <param name="arg2">The list of 1 position parameter arguments to the executing function</param>
		/// <param name="arg3">The list of 2 position parameter arguments to the executing function</param>
		/// <returns></returns>
		public static List<TResult> Mapcar<TResult, T1, T2, T3>(Func<T1, T2, T3, TResult> function, 
			List<T1> arg1, List<T2> arg2, List<T3> arg3)
		{
			List<TResult> result = new List<TResult>();

			int count = Compound<int>(Math.Min, new List<int> { arg1.Count, 
				arg2.Count, 
				arg3.Count });

			for (int i = 0; i < count; i++)
			{
				result.Add(function(arg1[i], 
					arg2[i],
					arg3[i]));
			}

			return result;
		}

		/// <summary>
		/// Returns a list of <typeparamref name="TResult"/> elements that is the result of executing a function with a list(s) supplied as arguments to the function.
		/// </summary>
		/// <typeparam name="TResult"></typeparam>
		/// <typeparam name="T1"></typeparam>
		/// <typeparam name="T2"></typeparam>
		/// <typeparam name="T3"></typeparam>
		/// <typeparam name="T4"></typeparam>
		/// <param name="function">The executing function parameter</param>
		/// <param name="arg1">The list of 0 position parameter arguments to the executing function</param>
		/// <param name="arg2">The list of 1 position parameter arguments to the executing function</param>
		/// <param name="arg3">The list of 2 position parameter arguments to the executing function</param>
		/// <param name="arg4">The list of 3 position parameter arguments to the executing function</param>
		/// <returns></returns>
		public static List<TResult> Mapcar<TResult, T1, T2, T3, T4>(Func<T1, T2, T3, T4, TResult> function, 
			List<T1> arg1, List<T2> arg2, List<T3> arg3, List<T4> arg4)
		{
			List<TResult> result = new List<TResult>();

			int count = Compound<int>(Math.Min, new List<int> { arg1.Count,
				arg2.Count,
				arg3.Count,
				arg4.Count });

			for (int i = 0; i < count; i++)
			{
				result.Add(function(arg1[i], 
					arg2[i], 
					arg3[i], 
					arg4[i]));
			}

			return result;
		}

		/// <summary>
		/// Returns a list of <typeparamref name="TResult"/> elements that is the result of executing a function with a list(s) supplied as arguments to the function.
		/// </summary>
		/// <typeparam name="TResult"></typeparam>
		/// <typeparam name="T1"></typeparam>
		/// <typeparam name="T2"></typeparam>
		/// <typeparam name="T3"></typeparam>
		/// <typeparam name="T4"></typeparam>
		/// <typeparam name="T5"></typeparam>
		/// <param name="function">The executing function parameter</param>
		/// <param name="arg1">The list of 0 position parameter arguments to the executing function</param>
		/// <param name="arg2">The list of 1 position parameter arguments to the executing function</param>
		/// <param name="arg3">The list of 2 position parameter arguments to the executing function</param>
		/// <param name="arg4">The list of 3 position parameter arguments to the executing function</param>
		/// <param name="arg5">The list of 4 position parameter arguments to the executing function</param>
		/// <returns></returns>
		public static List<TResult> Mapcar<TResult, T1, T2, T3, T4, T5>(Func<T1, T2, T3, T4, T5, TResult> function, 
			List<T1> arg1, List<T2> arg2, List<T3> arg3, List<T4> arg4, List<T5> arg5)
		{
			List<TResult> result = new List<TResult>();

			int count = Compound<int>(Math.Min, new List<int> { 
				arg1.Count, 
				arg2.Count, 
				arg3.Count, 
				arg4.Count, 
				arg5.Count });

			for (int i = 0; i < count; i++)
			{
				result.Add(function(arg1[i], 
					arg2[i], 
					arg3[i], 
					arg4[i], 
					arg5[i]));
			}

			return result;
		}

		/// <summary>
		/// Returns a list of <typeparamref name="TResult"/> elements that is the result of executing a function with a list(s) supplied as arguments to the function.
		/// </summary>
		/// <typeparam name="TResult"></typeparam>
		/// <typeparam name="T1"></typeparam>
		/// <typeparam name="T2"></typeparam>
		/// <typeparam name="T3"></typeparam>
		/// <typeparam name="T4"></typeparam>
		/// <typeparam name="T5"></typeparam>
		/// <typeparam name="T6"></typeparam>
		/// <param name="function">The executing function parameter</param>
		/// <param name="arg1">The list of 0 position parameter arguments to the executing function</param>
		/// <param name="arg2">The list of 1 position parameter arguments to the executing function</param>
		/// <param name="arg3">The list of 2 position parameter arguments to the executing function</param>
		/// <param name="arg4">The list of 3 position parameter arguments to the executing function</param>
		/// <param name="arg5">The list of 4 position parameter arguments to the executing function</param>
		/// <param name="arg6">The list of 5 position parameter arguments to the executing function</param>
		/// <returns></returns>
		public static List<TResult> Mapcar<TResult, T1, T2, T3, T4, T5, T6>(Func<T1, T2, T3, T4, T5, T6, TResult> function, 
			List<T1> arg1, List<T2> arg2, List<T3> arg3, List<T4> arg4, List<T5> arg5, List<T6> arg6)
		{
			List<TResult> result = new List<TResult>();

			int count = Compound<int>(Math.Min, new List<int> {
				arg1.Count,
				arg2.Count,
				arg3.Count,
				arg4.Count,
				arg5.Count,
				arg6.Count});

			for (int i = 0; i < count; i++)
				result.Add(function(arg1[i],
					arg2[i],
					arg3[i],
					arg4[i],
					arg5[i],
					arg6[i]));

			return result;
		}

		/// <summary>
		/// Returns a list of <typeparamref name="TResult"/> elements that is the result of executing a function with a list(s) supplied as arguments to the function.
		/// </summary>
		/// <typeparam name="TResult"></typeparam>
		/// <typeparam name="T1"></typeparam>
		/// <typeparam name="T2"></typeparam>
		/// <typeparam name="T3"></typeparam>
		/// <typeparam name="T4"></typeparam>
		/// <typeparam name="T5"></typeparam>
		/// <typeparam name="T6"></typeparam>
		/// <typeparam name="T7"></typeparam>
		/// <param name="function">The executing function parameter</param>
		/// <param name="arg1">The list of 0 position parameter arguments to the executing function</param>
		/// <param name="arg2">The list of 1 position parameter arguments to the executing function</param>
		/// <param name="arg3">The list of 2 position parameter arguments to the executing function</param>
		/// <param name="arg4">The list of 3 position parameter arguments to the executing function</param>
		/// <param name="arg5">The list of 4 position parameter arguments to the executing function</param>
		/// <param name="arg6">The list of 5 position parameter arguments to the executing function</param>
		/// <param name="arg7">The list of 6 position parameter arguments to the executing function</param>
		/// <returns></returns>
		public static List<TResult> Mapcar<TResult, T1, T2, T3, T4, T5, T6, T7>(Func<T1, T2, T3, T4, T5, T6, T7, TResult> function, 
			List<T1> arg1, List<T2> arg2, List<T3> arg3, List<T4> arg4, List<T5> arg5, List<T6> arg6, List<T7> arg7)
		{
			List<TResult> result = new List<TResult>();

			int count = Compound<int>(Math.Min, new List<int> {
				arg1.Count,
				arg2.Count,
				arg3.Count,
				arg4.Count,
				arg5.Count,
				arg6.Count,
				arg7.Count});

			for (int i = 0; i < count; i++)
				result.Add(function(arg1[i],
					arg2[i],
					arg3[i],
					arg4[i],
					arg5[i],
					arg6[i],
					arg7[i]));

			return result;
		}

		/// <summary>
		/// Returns a list of <typeparamref name="TResult"/> elements that is the result of executing a function with a list(s) supplied as arguments to the function.
		/// </summary>
		/// <typeparam name="TResult"></typeparam>
		/// <typeparam name="T1"></typeparam>
		/// <typeparam name="T2"></typeparam>
		/// <typeparam name="T3"></typeparam>
		/// <typeparam name="T4"></typeparam>
		/// <typeparam name="T5"></typeparam>
		/// <typeparam name="T6"></typeparam>
		/// <typeparam name="T7"></typeparam>
		/// <typeparam name="T8"></typeparam>
		/// <param name="function">The executing function parameter</param>
		/// <param name="arg1">The list of 0 position parameter arguments to the executing function</param>
		/// <param name="arg2">The list of 1 position parameter arguments to the executing function</param>
		/// <param name="arg3">The list of 2 position parameter arguments to the executing function</param>
		/// <param name="arg4">The list of 3 position parameter arguments to the executing function</param>
		/// <param name="arg5">The list of 4 position parameter arguments to the executing function</param>
		/// <param name="arg6">The list of 5 position parameter arguments to the executing function</param>
		/// <param name="arg7">The list of 6 position parameter arguments to the executing function</param>
		/// <param name="arg8">The list of 7 position parameter arguments to the executing function</param>
		/// <returns></returns>
		public static List<TResult> Mapcar<TResult, T1, T2, T3, T4, T5, T6, T7, T8>(Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function, 
			List<T1> arg1, List<T2> arg2, List<T3> arg3, List<T4> arg4, List<T5> arg5, List<T6> arg6, List<T7> arg7, List<T8> arg8)
		{
			List<TResult> result = new List<TResult>();

			int count = Compound(Math.Min, new List<int> {
				arg1.Count,
				arg2.Count,
				arg3.Count,
				arg4.Count,
				arg5.Count,
				arg6.Count,
				arg7.Count,
				arg8.Count});

			for (int i = 0; i < count; i++)
				result.Add(function(arg1[i],
					arg2[i],
					arg3[i],
					arg4[i],
					arg5[i],
					arg6[i],
					arg7[i],
					arg8[i]));

			return result;
		}

		#endregion
		#region Compounded Mapcar

		public static List<T> Mapcar<T>(Func<T, T, T> function, List<List<T>> arg1)
		{
			List<T> result = new List<T>();

			int count = arg1.Count;
			int length = Compound(Math.Min, v => v == 0, Mapcar(a => a.Count, arg1));

			List<T> args;
            for (int i = 0; i < length; i++)
			{
				args = new List<T>();

				// Create a list of arguments for the compound statement
                for (int j = 0; j < count; j++)
					args.Add(arg1[j][i]);

				result.Add(Compound(function, args));
			}
			
			return result;
		}

		#endregion
		#endregion
	}
}
