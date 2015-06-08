################################################################################
# Automatically-generated file. Do not edit!
################################################################################

# Add inputs and outputs from these tool invocations to the build variables 
CPP_SRCS += \
../src/AppResourceId.cpp \
../src/Argos1_1App.cpp \
../src/Argos1_1Entry.cpp \
../src/Argos1_1FormFactory.cpp \
../src/Argos1_1Frame.cpp \
../src/Argos1_1MainForm.cpp \
../src/Argos1_1PanelFactory.cpp 

OBJS += \
./src/AppResourceId.o \
./src/Argos1_1App.o \
./src/Argos1_1Entry.o \
./src/Argos1_1FormFactory.o \
./src/Argos1_1Frame.o \
./src/Argos1_1MainForm.o \
./src/Argos1_1PanelFactory.o 

CPP_DEPS += \
./src/AppResourceId.d \
./src/Argos1_1App.d \
./src/Argos1_1Entry.d \
./src/Argos1_1FormFactory.d \
./src/Argos1_1Frame.d \
./src/Argos1_1MainForm.d \
./src/Argos1_1PanelFactory.d 


# Each subdirectory must supply rules for building sources it contributes
src/%.o: ../src/%.cpp
	@echo 'Building file: $<'
	@echo 'Invoking: C++ Compiler'
	clang++.exe -I"pch" -I"C:\Users\KYN\workspace2.2\Argos1.1\inc" -O3 -g -Wall -c -fmessage-length=0 -target arm-tizen-linux-gnueabi -gcc-toolchain "C:/tizen-sdk/tools/smart-build-interface/../arm-linux-gnueabi-gcc-4.5/" -ccc-gcc-name arm-linux-gnueabi-g++ -march=armv7-a -mfloat-abi=softfp -mfpu=vfpv3-d16 -mtune=cortex-a8 -Wno-gnu -fPIE --sysroot="C:/tizen-sdk/platforms/tizen2.2/rootstraps/tizen-device-2.2.native" -I"C:/tizen-sdk/platforms/tizen2.2/rootstraps/tizen-device-2.2.native/usr/include/libxml2" -I"C:\tizen-sdk\library" -I"C:/tizen-sdk/platforms/tizen2.2/rootstraps/tizen-device-2.2.native/usr/include" -I"C:/tizen-sdk/platforms/tizen2.2/rootstraps/tizen-device-2.2.native/usr/include/osp" -MMD -MP -MF"$(@:%.o=%.d)" -MT"$(@:%.o=%.d)" -o "$@" "$<"
	@echo 'Finished building: $<'
	@echo ' '


