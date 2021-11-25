namespace FakeXrmEasy.Abstractions.Plugins.Enums
{
    /// <summary>
    /// Processing Step Stage
    /// </summary>
    public enum ProcessingStepStage
    {
        /// <summary>
        /// For the initial operation, this stage will occur before the main system operation.
        /// This provides an opportunity to include logic to cancel the operation before the database transaction.
        /// Subsequent operations triggered by extensions registered in other stages will pass through this stage as well but will be included within the transaction of the calling extensions.
        /// This stage occurs before any security checks are preformed to verify that the calling or logged-on user has the correct permission to perform the intended operation.
        /// </summary>
        Prevalidation = 10,
        /// <summary>
        /// Occurs before the main system operation and within the database transaction.
        /// If you want to change any values for an entity included in the message, you should do it here.
        /// Avoid canceling an operation here. Canceling will trigger a rollback of the transaction and have significant performance impact.
        /// </summary>
        Preoperation = 20,
        /// <summary>
        /// For internal use only except for Custom API and Custom virtual table data providers
        /// </summary>
        MainOperation = 30,
        /// <summary>
        /// Occurs after the main system operation and within the database transaction.
        /// Use this stage to modify any properties of the message before it is returned to the caller.
        /// Avoid applying changes to an entity included in the message because this will trigger a new Update event.
        /// Within the PostOperation stage you can register steps to use the asynchronous execution mode. These steps will run outside of the database transaction using the asynchronous service.
        /// </summary>
        Postoperation = 40
    }
}