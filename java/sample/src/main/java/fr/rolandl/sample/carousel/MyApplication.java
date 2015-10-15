package fr.rolandl.sample.carousel;

import com.facebook.stetho.Stetho;

/**
 * Created by simon.luckenuik on 2015-10-15.
 */
public class MyApplication extends android.app.Application {
    @Override public void onCreate() {
        super.onCreate();
        Stetho.initialize(
                Stetho.newInitializerBuilder(this)
                        .enableDumpapp(Stetho.defaultDumperPluginsProvider(this))
                        .enableWebKitInspector(Stetho.defaultInspectorModulesProvider(this))
                        .build());
    }
}
