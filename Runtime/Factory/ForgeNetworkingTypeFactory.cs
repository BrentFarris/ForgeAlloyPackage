﻿using Forge.DataStructures;
using Forge.Engine;
using Forge.Networking;
using Forge.Networking.Messaging;
using Forge.Networking.Messaging.Messages;
using Forge.Networking.Messaging.Paging;
using Forge.Networking.Players;
using Forge.Networking.Sockets;

namespace Forge.Factory
{
	public class ForgeNetworkingTypeFactory : TypeFactory, INetworkTypeFactory
	{
		public override void PrimeRegistry()
		{
			Register<IPlayerRepository, ForgePlayerRepository>();
			Register<INetworkMediator, ForgeNetworkMediator>();
			Register<IMessageReceiptSignature, ForgeMessageReceipt>();
			Register<IMessageBus, ForgeMessageBus>();
			Register<IMessageRepository, ForgeMessageRepository>();
			Register<IMessagePage, ForgeMessagePage>();
			Register<IPagenatedMessage, ForgePagenatedMessage>();
			Register<IMessageDestructor, ForgeMessageDestructor>();
			Register<IMessageConstructor, ForgeMessageConstructor>();
			Register<IMessageBufferInterpreter, ForgeMessageBufferInterpreter>();
			Register<ISocket, ForgeUDPSocket>();
			Register<IServerSocket, ForgeUDPSocket>();
			Register<IClientSocket, ForgeUDPSocket>();
			Register<ISocketServerFacade, ForgeUDPSocketServerFacade>();
			Register<ISocketClientFacade, ForgeUDPSocketClientFacade>();
			Register<INetPlayer, ForgePlayer>();
			Register<IMessageRepeater, ForgeMessageRepeater>();
			Register<IPlayerSignature, ForgePlayerSignature>();
			Register<ISignature, ForgeSignature>();
			Register<IPlayerTimeoutBridge, ForgePlayerTimeoutBridge>();

			Register<IChallengeMessage, ForgeConnectChallengeMessage>();
			Register<IChallengeResponseMessage, ForgeConnectChallengeResponseMessage>();
		}
	}
}
