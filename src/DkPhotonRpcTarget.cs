namespace Tool.Compet.Photon {
	public enum DkPhotonRpcTarget {
		/// Send message to all clients (include this client) but it executes RPC-method immediately
		/// at local for this client.
		ALL,

		/// Like as `ALL`, but it sends message to all clients throught server.
		/// That is, it does not locally execute RPC-method for this client.
		/// Benefit: in general, all clients can receive message at same order from server.
		ALL_VIA_SERVER,

		/// Only send message to other clients (exclude this client).
		OTHERS,
	}
}
