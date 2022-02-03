[Flags]
public enum ETableRight
{
  /// <summary>
  /// The row should be hidden from the user.
  /// </summary>
  None = 0,
  /// <summary>
  /// The user is allowed to see the row.
  /// </summary>
  Select = 1,
  /// <summary>
  /// The user is allowed to modify the values in this row.
  /// Applies to rows with id > 0.
  /// Row with id = 0 needs insert rights instead.
  /// </summary>
  Update = 2,
  /// <summary>
  /// The user is allowed to add new rows to the table.
  /// Implies update rights on a row with id = 0.
  /// </summary>
  Insert = 4,
  /// <summary>
  /// The user is allowed to delete this row.
  /// </summary>
  Delete = 8,
  /// <summary>
  /// A flag used to indicate that some fields may be hidden.
  /// The user has no Select access, but he will have Filtering.
  /// Used on rows where the visibility flag may affect what the user can see (e.g.: private appointments).
  /// </summary>
  Filtering = 16,
  /// <summary>
  /// A hint flag used to indicate that some fields may not be updatable, even though
  /// the user has update access to the row.
  /// Used on rows where some fields are locked down by business rules or integrity constraints.
  /// (e.g.: the database owner contact.name field is read-only. An invitation's contact id is read-only)
  /// </summary>
  RestrictedUpdate = 32,
  /// <summary>
  /// Magic value to indicate not initialized
  /// </summary>
  Uninitialized = 128,
};