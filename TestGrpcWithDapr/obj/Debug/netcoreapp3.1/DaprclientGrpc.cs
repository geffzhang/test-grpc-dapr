// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/daprclient.proto
// </auto-generated>
// Original file comments:
// ------------------------------------------------------------
// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.
// ------------------------------------------------------------
//
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace Dapr.Client.Autogen.Grpc.v1 {
  /// <summary>
  /// DaprClient service allows user application to interact with Dapr runtime.
  /// User application needs to implement DaprClient service if it needs to
  /// receive message from dapr runtime.
  /// </summary>
  public static partial class DaprClient
  {
    static readonly string __ServiceName = "dapr.proto.daprclient.v1.DaprClient";

    static readonly grpc::Marshaller<global::Dapr.Client.Autogen.Grpc.v1.InvokeRequest> __Marshaller_dapr_proto_common_v1_InvokeRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Dapr.Client.Autogen.Grpc.v1.InvokeRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Dapr.Client.Autogen.Grpc.v1.InvokeResponse> __Marshaller_dapr_proto_common_v1_InvokeResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Dapr.Client.Autogen.Grpc.v1.InvokeResponse.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Google.Protobuf.WellKnownTypes.Empty> __Marshaller_google_protobuf_Empty = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Protobuf.WellKnownTypes.Empty.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Dapr.Client.Autogen.Grpc.v1.GetTopicSubscriptionsEnvelope> __Marshaller_dapr_proto_daprclient_v1_GetTopicSubscriptionsEnvelope = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Dapr.Client.Autogen.Grpc.v1.GetTopicSubscriptionsEnvelope.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Dapr.Client.Autogen.Grpc.v1.GetBindingsSubscriptionsEnvelope> __Marshaller_dapr_proto_daprclient_v1_GetBindingsSubscriptionsEnvelope = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Dapr.Client.Autogen.Grpc.v1.GetBindingsSubscriptionsEnvelope.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Dapr.Client.Autogen.Grpc.v1.BindingEventEnvelope> __Marshaller_dapr_proto_daprclient_v1_BindingEventEnvelope = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Dapr.Client.Autogen.Grpc.v1.BindingEventEnvelope.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Dapr.Client.Autogen.Grpc.v1.BindingResponseEnvelope> __Marshaller_dapr_proto_daprclient_v1_BindingResponseEnvelope = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Dapr.Client.Autogen.Grpc.v1.BindingResponseEnvelope.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Dapr.Client.Autogen.Grpc.v1.CloudEventEnvelope> __Marshaller_dapr_proto_daprclient_v1_CloudEventEnvelope = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Dapr.Client.Autogen.Grpc.v1.CloudEventEnvelope.Parser.ParseFrom);

    static readonly grpc::Method<global::Dapr.Client.Autogen.Grpc.v1.InvokeRequest, global::Dapr.Client.Autogen.Grpc.v1.InvokeResponse> __Method_OnInvoke = new grpc::Method<global::Dapr.Client.Autogen.Grpc.v1.InvokeRequest, global::Dapr.Client.Autogen.Grpc.v1.InvokeResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "OnInvoke",
        __Marshaller_dapr_proto_common_v1_InvokeRequest,
        __Marshaller_dapr_proto_common_v1_InvokeResponse);

    static readonly grpc::Method<global::Google.Protobuf.WellKnownTypes.Empty, global::Dapr.Client.Autogen.Grpc.v1.GetTopicSubscriptionsEnvelope> __Method_GetTopicSubscriptions = new grpc::Method<global::Google.Protobuf.WellKnownTypes.Empty, global::Dapr.Client.Autogen.Grpc.v1.GetTopicSubscriptionsEnvelope>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetTopicSubscriptions",
        __Marshaller_google_protobuf_Empty,
        __Marshaller_dapr_proto_daprclient_v1_GetTopicSubscriptionsEnvelope);

    static readonly grpc::Method<global::Google.Protobuf.WellKnownTypes.Empty, global::Dapr.Client.Autogen.Grpc.v1.GetBindingsSubscriptionsEnvelope> __Method_GetBindingsSubscriptions = new grpc::Method<global::Google.Protobuf.WellKnownTypes.Empty, global::Dapr.Client.Autogen.Grpc.v1.GetBindingsSubscriptionsEnvelope>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetBindingsSubscriptions",
        __Marshaller_google_protobuf_Empty,
        __Marshaller_dapr_proto_daprclient_v1_GetBindingsSubscriptionsEnvelope);

    static readonly grpc::Method<global::Dapr.Client.Autogen.Grpc.v1.BindingEventEnvelope, global::Dapr.Client.Autogen.Grpc.v1.BindingResponseEnvelope> __Method_OnBindingEvent = new grpc::Method<global::Dapr.Client.Autogen.Grpc.v1.BindingEventEnvelope, global::Dapr.Client.Autogen.Grpc.v1.BindingResponseEnvelope>(
        grpc::MethodType.Unary,
        __ServiceName,
        "OnBindingEvent",
        __Marshaller_dapr_proto_daprclient_v1_BindingEventEnvelope,
        __Marshaller_dapr_proto_daprclient_v1_BindingResponseEnvelope);

    static readonly grpc::Method<global::Dapr.Client.Autogen.Grpc.v1.CloudEventEnvelope, global::Google.Protobuf.WellKnownTypes.Empty> __Method_OnTopicEvent = new grpc::Method<global::Dapr.Client.Autogen.Grpc.v1.CloudEventEnvelope, global::Google.Protobuf.WellKnownTypes.Empty>(
        grpc::MethodType.Unary,
        __ServiceName,
        "OnTopicEvent",
        __Marshaller_dapr_proto_daprclient_v1_CloudEventEnvelope,
        __Marshaller_google_protobuf_Empty);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Dapr.Client.Autogen.Grpc.v1.DaprclientReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of DaprClient</summary>
    [grpc::BindServiceMethod(typeof(DaprClient), "BindService")]
    public abstract partial class DaprClientBase
    {
      public virtual global::System.Threading.Tasks.Task<global::Dapr.Client.Autogen.Grpc.v1.InvokeResponse> OnInvoke(global::Dapr.Client.Autogen.Grpc.v1.InvokeRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::Dapr.Client.Autogen.Grpc.v1.GetTopicSubscriptionsEnvelope> GetTopicSubscriptions(global::Google.Protobuf.WellKnownTypes.Empty request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::Dapr.Client.Autogen.Grpc.v1.GetBindingsSubscriptionsEnvelope> GetBindingsSubscriptions(global::Google.Protobuf.WellKnownTypes.Empty request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::Dapr.Client.Autogen.Grpc.v1.BindingResponseEnvelope> OnBindingEvent(global::Dapr.Client.Autogen.Grpc.v1.BindingEventEnvelope request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::Google.Protobuf.WellKnownTypes.Empty> OnTopicEvent(global::Dapr.Client.Autogen.Grpc.v1.CloudEventEnvelope request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for DaprClient</summary>
    public partial class DaprClientClient : grpc::ClientBase<DaprClientClient>
    {
      /// <summary>Creates a new client for DaprClient</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public DaprClientClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for DaprClient that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public DaprClientClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected DaprClientClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected DaprClientClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      public virtual global::Dapr.Client.Autogen.Grpc.v1.InvokeResponse OnInvoke(global::Dapr.Client.Autogen.Grpc.v1.InvokeRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return OnInvoke(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::Dapr.Client.Autogen.Grpc.v1.InvokeResponse OnInvoke(global::Dapr.Client.Autogen.Grpc.v1.InvokeRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_OnInvoke, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::Dapr.Client.Autogen.Grpc.v1.InvokeResponse> OnInvokeAsync(global::Dapr.Client.Autogen.Grpc.v1.InvokeRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return OnInvokeAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::Dapr.Client.Autogen.Grpc.v1.InvokeResponse> OnInvokeAsync(global::Dapr.Client.Autogen.Grpc.v1.InvokeRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_OnInvoke, null, options, request);
      }
      public virtual global::Dapr.Client.Autogen.Grpc.v1.GetTopicSubscriptionsEnvelope GetTopicSubscriptions(global::Google.Protobuf.WellKnownTypes.Empty request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetTopicSubscriptions(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::Dapr.Client.Autogen.Grpc.v1.GetTopicSubscriptionsEnvelope GetTopicSubscriptions(global::Google.Protobuf.WellKnownTypes.Empty request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetTopicSubscriptions, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::Dapr.Client.Autogen.Grpc.v1.GetTopicSubscriptionsEnvelope> GetTopicSubscriptionsAsync(global::Google.Protobuf.WellKnownTypes.Empty request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetTopicSubscriptionsAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::Dapr.Client.Autogen.Grpc.v1.GetTopicSubscriptionsEnvelope> GetTopicSubscriptionsAsync(global::Google.Protobuf.WellKnownTypes.Empty request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetTopicSubscriptions, null, options, request);
      }
      public virtual global::Dapr.Client.Autogen.Grpc.v1.GetBindingsSubscriptionsEnvelope GetBindingsSubscriptions(global::Google.Protobuf.WellKnownTypes.Empty request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetBindingsSubscriptions(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::Dapr.Client.Autogen.Grpc.v1.GetBindingsSubscriptionsEnvelope GetBindingsSubscriptions(global::Google.Protobuf.WellKnownTypes.Empty request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetBindingsSubscriptions, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::Dapr.Client.Autogen.Grpc.v1.GetBindingsSubscriptionsEnvelope> GetBindingsSubscriptionsAsync(global::Google.Protobuf.WellKnownTypes.Empty request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetBindingsSubscriptionsAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::Dapr.Client.Autogen.Grpc.v1.GetBindingsSubscriptionsEnvelope> GetBindingsSubscriptionsAsync(global::Google.Protobuf.WellKnownTypes.Empty request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetBindingsSubscriptions, null, options, request);
      }
      public virtual global::Dapr.Client.Autogen.Grpc.v1.BindingResponseEnvelope OnBindingEvent(global::Dapr.Client.Autogen.Grpc.v1.BindingEventEnvelope request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return OnBindingEvent(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::Dapr.Client.Autogen.Grpc.v1.BindingResponseEnvelope OnBindingEvent(global::Dapr.Client.Autogen.Grpc.v1.BindingEventEnvelope request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_OnBindingEvent, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::Dapr.Client.Autogen.Grpc.v1.BindingResponseEnvelope> OnBindingEventAsync(global::Dapr.Client.Autogen.Grpc.v1.BindingEventEnvelope request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return OnBindingEventAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::Dapr.Client.Autogen.Grpc.v1.BindingResponseEnvelope> OnBindingEventAsync(global::Dapr.Client.Autogen.Grpc.v1.BindingEventEnvelope request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_OnBindingEvent, null, options, request);
      }
      public virtual global::Google.Protobuf.WellKnownTypes.Empty OnTopicEvent(global::Dapr.Client.Autogen.Grpc.v1.CloudEventEnvelope request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return OnTopicEvent(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::Google.Protobuf.WellKnownTypes.Empty OnTopicEvent(global::Dapr.Client.Autogen.Grpc.v1.CloudEventEnvelope request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_OnTopicEvent, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::Google.Protobuf.WellKnownTypes.Empty> OnTopicEventAsync(global::Dapr.Client.Autogen.Grpc.v1.CloudEventEnvelope request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return OnTopicEventAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::Google.Protobuf.WellKnownTypes.Empty> OnTopicEventAsync(global::Dapr.Client.Autogen.Grpc.v1.CloudEventEnvelope request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_OnTopicEvent, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override DaprClientClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new DaprClientClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(DaprClientBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_OnInvoke, serviceImpl.OnInvoke)
          .AddMethod(__Method_GetTopicSubscriptions, serviceImpl.GetTopicSubscriptions)
          .AddMethod(__Method_GetBindingsSubscriptions, serviceImpl.GetBindingsSubscriptions)
          .AddMethod(__Method_OnBindingEvent, serviceImpl.OnBindingEvent)
          .AddMethod(__Method_OnTopicEvent, serviceImpl.OnTopicEvent).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static void BindService(grpc::ServiceBinderBase serviceBinder, DaprClientBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_OnInvoke, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Dapr.Client.Autogen.Grpc.v1.InvokeRequest, global::Dapr.Client.Autogen.Grpc.v1.InvokeResponse>(serviceImpl.OnInvoke));
      serviceBinder.AddMethod(__Method_GetTopicSubscriptions, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Google.Protobuf.WellKnownTypes.Empty, global::Dapr.Client.Autogen.Grpc.v1.GetTopicSubscriptionsEnvelope>(serviceImpl.GetTopicSubscriptions));
      serviceBinder.AddMethod(__Method_GetBindingsSubscriptions, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Google.Protobuf.WellKnownTypes.Empty, global::Dapr.Client.Autogen.Grpc.v1.GetBindingsSubscriptionsEnvelope>(serviceImpl.GetBindingsSubscriptions));
      serviceBinder.AddMethod(__Method_OnBindingEvent, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Dapr.Client.Autogen.Grpc.v1.BindingEventEnvelope, global::Dapr.Client.Autogen.Grpc.v1.BindingResponseEnvelope>(serviceImpl.OnBindingEvent));
      serviceBinder.AddMethod(__Method_OnTopicEvent, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Dapr.Client.Autogen.Grpc.v1.CloudEventEnvelope, global::Google.Protobuf.WellKnownTypes.Empty>(serviceImpl.OnTopicEvent));
    }

  }
}
#endregion
