package com.github.nitro1231.optifine;

import java.io.File;
import java.lang.reflect.Method;
import java.net.URL;
import java.net.URLClassLoader;

public class OptiFineAutoInstall {
    public static void main(String[] args) {
        // args[0]: OptiFine.jar path
        // args[1]: .minecraft folder

        if (args.length < 2) {
            throw new IllegalArgumentException("[Error] Missing parameters.");
        }

        File jarPath = new File(args[0]); // OptiFine.jar path
        if (!jarPath.isFile()) {
            throw new IllegalArgumentException("[Error] File does not exist at the given path: " + args[0]);
        }

        File installDir = new File(args[1]); // .minecraft folder
        if (!installDir.exists()) {
            throw new IllegalArgumentException("[Error] Minecraft directory doesn't exist: " + args[1]);
        }

        try {
            URLClassLoader classLoader = new URLClassLoader(new URL[]{jarPath.toURI().toURL()}, OptiFineAutoInstall.class.getClassLoader());
            Class<?> jarClass = Class.forName("optifine.Installer", true, classLoader);
            Method method = jarClass.getDeclaredMethod("doInstall", File.class);
            method.invoke(null, installDir);
            System.out.println("[Success] OptiFine has been successfully installed.");
            System.exit(0);
        } catch (Exception e) {
            System.err.println("[Error] File is not a valid: " + jarPath.getName());
            e.printStackTrace();
        }
    }
}
