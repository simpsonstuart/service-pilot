using System;
using Xamarin.Forms;
using System.Windows.Input;

namespace ServiceTime.Adapters
{
	public class EventCommandAdapter<T, TEventArgs>
		where T : class
		where TEventArgs : EventArgs
	{
		private readonly BindableObject _dest;
		private readonly BindableProperty _property;
		private readonly Func<T,TEventArgs, object> _commandParameterSelector;


		public EventCommandAdapter(BindableObject dest, BindableProperty property, T source, Action<T, EventHandler<TEventArgs>> eventAttachAction, Func<T,TEventArgs, object> commandParameterSelector)
		{
			Guard.NotNull (() => dest, dest);
			Guard.NotNull (() => property, property);
			Guard.NotNull (() => source, source);
			Guard.NotNull (() => eventAttachAction, eventAttachAction);
			Guard.NotNull (() => commandParameterSelector, commandParameterSelector);


			_dest = dest;
			_property = property;
			_commandParameterSelector = commandParameterSelector;

			eventAttachAction(source, EventHandler);
		}

		protected virtual void EventHandler (object sender, TEventArgs e)
		{
			var cmd = _dest.GetValue(_property) as ICommand;
			var parameter = _commandParameterSelector (sender as T, e);

			if (null != cmd && cmd.CanExecute(parameter))
			{
				cmd.Execute (parameter);
			}
		}
	}
}

