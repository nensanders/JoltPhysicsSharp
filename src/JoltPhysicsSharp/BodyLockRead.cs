// Copyright © Amer Koleci and Contributors.
// Licensed under the MIT License (MIT). See LICENSE in the repository root for more information.

namespace JoltPhysicsSharp;

public readonly struct BodyLockRead
{
    public readonly BodyLockInterface LockInterface;
    public readonly IntPtr Mutex; /* JPH_SharedMutex */
    public readonly Body Body;
}
