plugins {
    java
}

group = "com.github.nitro1231"
version = "1.0"

tasks {
    withType<JavaCompile> {
        options.encoding = "UTF-8"
        sourceCompatibility = "1.8"
        targetCompatibility = "1.8"
    }
    
    withType<Javadoc> {
        options.encoding = "UTF-8"
    }

    withType<Jar> {
        manifest {
            attributes["Main-Class"] = "${project.group}.optifine.OptiFineAutoInstall"
        }
    }
}