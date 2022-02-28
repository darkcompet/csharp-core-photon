namespace Tool.Compet.Photon {
	/// Declare type for message in communication between server and client.
	/// Values in range [0 -> 255]
	public enum DkPhotonMessageType {
		/// For calculate round-trip-time.
		PING,

		/// Indicates the message targets to call a service methods
		/// which be declared inside service interface (shared between server and client).
		/// Both server and client must implement service methods for communication.
		///
		/// In general, we use this type when we want server side implements some logic for us
		/// like `Join to a room, Leave from a room,...`.
		SERVICE,

		/// This is like as `SERVICE` type, but server side does not know/implement
		/// service methods which be declared at client side.
		/// Only client needs to implement service methods which be annotated with `DkPhotonRPC`.
		///
		/// It is convenience when we want to communicate between clients only, and don't need
		/// server side implementation.
		RPC,
	}
}
