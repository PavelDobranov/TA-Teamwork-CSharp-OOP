namespace AcademySystem
{
    using System;

    public static class ErrorMessage
    {
        public static readonly string OutOfRangeMessage = "Value must be in range {0} - {1}";
        public static readonly string NullOrEmptyPropertyMessage = "Property {0} must have value";
        public static readonly string NullObjectMessage = "Object {0} must have value";
        public static readonly string InvalidDurationMessage = "Invalid time range. {0} must be smaller than {1}";
        public static readonly string InvalidRangeMessage = "{0} must be in range {1} - {2}";

    }
}