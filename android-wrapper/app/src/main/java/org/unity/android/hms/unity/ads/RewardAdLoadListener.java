package org.unity.android.hms.unity.ads;

public interface RewardAdLoadListener {
    void onRewardedLoaded();
    void onRewardAdFailedToLoad(final int errorCode);
}
