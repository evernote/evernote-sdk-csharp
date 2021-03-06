/**
 * Autogenerated by Thrift Compiler (1.0.0-dev)
 *
 * DO NOT EDIT UNLESS YOU ARE SURE THAT YOU KNOW WHAT YOU ARE DOING
 *  @generated
 */

namespace Evernote.EDAM.Type
{
  /// <summary>
  /// This enumeration defines the possible states of a premium account
  /// 
  /// NONE:    the user has never attempted to become a premium subscriber
  /// 
  /// PENDING: the user has requested a premium account but their charge has not
  ///   been confirmed
  /// 
  /// ACTIVE:  the user has been charged and their premium account is in good
  ///  standing
  /// 
  /// FAILED:  the system attempted to charge the was denied. We will periodically attempt to
  ///  re-validate their order.
  /// 
  /// CANCELLATION_PENDING: the user has requested that no further charges be made
  ///   but the current account is still active.
  /// 
  /// CANCELED: the premium account was canceled either because of failure to pay
  ///   or user cancelation. No more attempts will be made to activate the account.
  /// </summary>
  public enum PremiumOrderStatus
  {
    NONE = 0,
    PENDING = 1,
    ACTIVE = 2,
    FAILED = 3,
    CANCELLATION_PENDING = 4,
    CANCELED = 5,
  }
}
