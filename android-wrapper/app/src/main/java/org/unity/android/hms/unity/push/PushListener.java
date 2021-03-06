package org.unity.android.hms.unity.push;

import com.huawei.hms.push.RemoteMessage;

public interface PushListener {
    void onNewToken(String token);

    void onTokenError(Exception e);

    void onMessageReceived(RemoteMessage remoteMessage);
}
