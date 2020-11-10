package org.unity.android.hms.unity;

import android.content.Intent;

public interface GenericBridgeCallback {
    void onSuccess(final Intent data);
    void onFailure(final Exception exception);
}
