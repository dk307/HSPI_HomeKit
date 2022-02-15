﻿namespace HomeKit.Model
{
    public enum HAPStatus
    {
        SUCCESS = 0,
        INSUFFICIENT_PRIVILEGES = -70401,
        SERVICE_COMMUNICATION_FAILURE = -70402,
        RESOURCE_BUSY = -70403,
        READ_ONLY_CHARACTERISTIC = -70404, // cannot write to read only
        WRITE_ONLY_CHARACTERISTIC = -70405, // cannot read from write only
        NOTIFICATION_NOT_SUPPORTED = -70406,
        OUT_OF_RESOURCE = -70407,
        OPERATION_TIMED_OUT = -70408,
        RESOURCE_DOES_NOT_EXIST = -70409,
        INVALID_VALUE_IN_REQUEST = -70410,
        INSUFFICIENT_AUTHORIZATION = -70411,
        NOT_ALLOWED_IN_CURRENT_STATE = -70412,
    }
}