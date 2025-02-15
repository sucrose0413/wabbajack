﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using ReactiveUI;

namespace Wabbajack.Lib
{
    public abstract class ConfirmationIntervention : AUserIntervention
    {
        public enum Choice
        {
            Continue,
            Abort
        }

        private TaskCompletionSource<Choice> _source = new TaskCompletionSource<Choice>();
        public Task<Choice> Task => _source.Task;

        public ICommand ConfirmCommand { get; }

        public ConfirmationIntervention()
        {
            ConfirmCommand = ReactiveCommand.Create(() => Confirm());
        }

        public override void Cancel()
        {
            Handled = true;
            _source.SetResult(Choice.Abort);
        }

        public void Confirm()
        {
            Handled = true;
            _source.SetResult(Choice.Continue);
        }
    }
}
