package org.unity.android.hms.unity.base;

import android.content.Intent;
import android.content.IntentSender;
import android.util.Log;

import com.huawei.hms.support.api.client.Status;

import org.unity.android.hms.unity.BridgeType;
import org.unity.android.hms.unity.GenericBridgeCallback;
import org.unity.android.hms.unity.activity.NativeBridgeActivity;

public class StatusBridge {
    public static final String STATUS = "STATUS";

    private static final String TAG = StatusBridge.class.getSimpleName();

    private static final int CODE = BridgeType.STATUS;

    private static Status status;
    private static GenericBridgeCallback callback;

    public static void receiveStartResolutionForResult(final Status status, final GenericBridgeCallback callback) {
        Log.d(TAG, "[HMS] receiveStartResolutionForResult");
        StatusBridge.status = status;
        StatusBridge.callback = callback;
        NativeBridgeActivity.start(STATUS);
    }

    public static void launchStartResolutionForResult(final NativeBridgeActivity activity) {
        try {
            Log.d(TAG, "[HMS] launchStartResolutionForResult");
            status.startResolutionForResult(activity, CODE);
        } catch (IntentSender.SendIntentException e) {
            callback.onFailure(e);
        }
    }

    public static void returnStartResolutionForResult(final Intent data) {
        Log.d(TAG, "[HMS] returnStartResolutionForResult");
        callback.onSuccess(data);
    }

    public static boolean HasStatus() {
        return status != null;
    }
}
