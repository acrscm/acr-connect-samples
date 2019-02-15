using System;
using System.Security.Permissions;
using System.Windows.Forms;

namespace Acr.Connect.Samples.WinForms.RefreshToken
{
    internal class WebBrowserEx : WebBrowser
    {
        private delegate void BeforeNavigate2Delegate(object pDisp, ref dynamic url, ref dynamic Flags, ref dynamic TargetFrameName, ref dynamic PostData, ref dynamic Headers, ref bool Cancel);
        private delegate void NavigateErrorDelegate(object pDisp, ref object url, ref object Frame, ref object StatusCode, ref bool Cancel);

        private BeforeNavigate2Delegate _beforeNavigate2Delegate;
        private NavigateErrorDelegate _navigateErrorDelegate;
        private bool _subscribed;

        [PermissionSet(SecurityAction.LinkDemand, Name = "FullTrust")]
        public WebBrowserEx()
        {
            _beforeNavigate2Delegate = new BeforeNavigate2Delegate(OnBeforeNavigate2);
            _navigateErrorDelegate = new NavigateErrorDelegate(OnNavigateError);
        }

        protected override void CreateSink()
        {
            base.CreateSink();

            if (_subscribed) return;
            dynamic activeXControl = ActiveXInstance;
            activeXControl.BeforeNavigate2 += _beforeNavigate2Delegate;
            activeXControl.NavigateError += _navigateErrorDelegate;
            _subscribed = true;
        }

        protected override void DetachSink()
        {
            if (_subscribed)
            {
                dynamic activeXControl = ActiveXInstance;
                activeXControl.BeforeNavigate2 -= _beforeNavigate2Delegate;
                activeXControl.NavigateError -= _navigateErrorDelegate;
                _subscribed = false;
            }

            base.DetachSink();
        }

        internal event EventHandler<BeforeNavigate2EventArgs> BeforeNavigate2;
        internal event EventHandler<NavigateErrorEventArgs> NavigateError;

        private void OnBeforeNavigate2(object pDisp, ref dynamic url, ref dynamic Flags, ref dynamic TargetFrameName, ref dynamic PostData, ref dynamic Headers, ref bool Cancel)
        {
            var handler = BeforeNavigate2;
            if (handler != null)
            {
                var args = new BeforeNavigate2EventArgs((string)url, (string)TargetFrameName, (byte[])PostData, (string)Headers);
                handler(this, args);
                Cancel = args.Cancel;
            }
        }

        private void OnNavigateError(object pDisp, ref object url, ref object frame, ref object statusCode, ref bool cancel)
        {
            var handler = NavigateError;
            if (handler != null)
            {
                var args = new NavigateErrorEventArgs((string)url, (string)frame, (int)statusCode);
                handler(this, args);
                cancel = args.Cancel;
            }
        }

        internal class BeforeNavigate2EventArgs : EventArgs
        {
            public BeforeNavigate2EventArgs(string url, string targetFrameName, byte[] postData, string headers)
            {
                Url = url;
                TargetFrameName = targetFrameName;
                PostData = postData;
                Headers = headers;
                Cancel = false;
            }

            public string Url { get; }
            public string TargetFrameName { get; }
            public byte[] PostData { get; }
            public string Headers { get; }
            public bool Cancel { get; set; }
        }

        internal class NavigateErrorEventArgs : EventArgs
        {
            public NavigateErrorEventArgs(string url, string frame, int statusCode)
            {
                Url = url;
                Frame = frame;
                StatusCode = statusCode;
                Cancel = false;
            }

            public string Url { get; }
            public string Frame { get; }
            public int StatusCode { get; }
            public bool Cancel { get; set; }
        }
    }
}