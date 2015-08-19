using System;
using System.Text;

namespace Org.Kevoree.Core.Api.Protocol
{
	public class Protocol
	{
		public static readonly string REGISTER = "register";
		public static readonly int REGISTER_TYPE = 0;

		public static readonly string PUSH = "push";
		public static readonly int PUSH_TYPE = 1;

		public static readonly string PULL = "pull";
		public static readonly int PULL_TYPE = 2;

		public static readonly string DIFF = "diff";
		public static readonly string SEP = "/";


		public interface Message {
			int getType();

			string toRaw();
		}

		public class RegisterMessage: Message {

			public RegisterMessage(String nodeName, string model) {
				this.nodeName = nodeName;
				this.model = model;
			}

			public string getNodeName() {
				return nodeName;
			}

			private string nodeName;

			public string getModel() {
				return model;
			}

			private string model;

			public int getType() {
				return REGISTER_TYPE;
			}

			public string toRaw() {
				return REGISTER + SEP + nodeName + SEP + model;
			}
		}

		public class PullMessage: Message {

			public int getType() {
				return PULL_TYPE;
			}

			public string toRaw() {
				return PULL;
			}
		}

		public class PushMessage: Message {

			public PushMessage(String model) {
				this.model = model;
			}

			public string getModel() {
				return model;
			}

			private string model;

			public int getType() {
				return PUSH_TYPE;
			}

			public string toRaw() {
				return PUSH + SEP + model;
			}
		}

		public static Message parse(String msg) {
			if (msg.StartsWith(REGISTER)) {
				String payload = msg.Substring(REGISTER.Length + SEP.Length);
				int i = 0;
				char ch = payload[i];
				StringBuilder buffer = new StringBuilder();
				while (i < payload.Length && ch != '/') {
					i++;
					buffer.Append(ch);
					ch = payload[i];
				}
				if (ch != '/') {
					buffer.Append(ch);
				} else {
					i++;
				}
				String model = null;
				if (i < payload.Length) {
					model = payload.Substring(i, payload.Length);
				}
				return new Protocol.RegisterMessage(buffer.ToString(), model);
			}
			if (msg.StartsWith(PUSH + SEP)) {
				String model = msg.Substring(PUSH.Length + SEP.Length);
				return new PushMessage(model);
			}
			if (msg.StartsWith(PULL)) {
				return new PullMessage();
			}
			/*
        retro compat
        if (msg.startsWith("get")) {
            return new PullMessage();
        }
        */

			return null;
		}
	}
}

