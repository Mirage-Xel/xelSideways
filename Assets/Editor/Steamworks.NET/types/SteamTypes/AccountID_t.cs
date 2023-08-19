// This file is provided under The MIT License as part of Steamworks.NET.
// Copyright (c) 2013-2015 Riley Labrecque
// Please see the included LICENSE.txt for additional information.

// Changes to this file will be reverted when you update Steamworks.NET

#pragma warning disable 436
namespace Steamworks {
	public struct AccountID_t : System.IEquatable<AccountID_t>, System.IComparable<AccountID_t> {
		public uint m_AccountID;

		public AccountID_t(uint value) {
			m_AccountID = value;
		}

		public override string ToString() {
			return m_AccountID.ToString();
		}

		public override bool Equals(object other) {
			return other is AccountID_t && this == (AccountID_t)other;
		}

		public override int GetHashCode() {
			return m_AccountID.GetHashCode();
		}

		public static bool operator ==(AccountID_t x, AccountID_t y) {
			return x.m_AccountID == y.m_AccountID;
		}

		public static bool operator !=(AccountID_t x, AccountID_t y) {
			return !(x == y);
		}

		public static explicit operator AccountID_t(uint value) {
			return new AccountID_t(value);
		}

		public static explicit operator uint(AccountID_t that) {
			return that.m_AccountID;
		}

		public bool Equals(AccountID_t other) {
			return m_AccountID == other.m_AccountID;
		}

		public int CompareTo(AccountID_t other) {
			return m_AccountID.CompareTo(other.m_AccountID);
		}
	}
}
