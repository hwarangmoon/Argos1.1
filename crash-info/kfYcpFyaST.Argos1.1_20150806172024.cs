S/W Version Information
Model: Ref.Device-ODROID-U3
Tizen-Version: 2.2
Build-Number: Tizen_Ref.Device-ODROID-U3_20141105.1800
Build-Date: 2014.11.05 18:00:53

Crash Information
Process Name: Argos1.1
PID: 2220
Date: 2015-08-06 17:20:24(GMT+0900)
Executable File Path: /opt/apps/kfYcpFyaST/bin/Argos1.1
This process is multi-thread process
pid=2220 tid=2220
Signal: 11
      (SIGSEGV)
      si_code: -6
      signal sent by tkill (sent by pid 2220, uid 5000)

Register Information
r0   = 0xbea26d60, r1   = 0x00000004
r2   = 0x00000004, r3   = 0x00000000
r4   = 0x00000066, r5   = 0x00000000
r6   = 0x00000004, r7   = 0x001bb4d8
r8   = 0x00000010, r9   = 0xbea26d60
r10  = 0x00000004, fp   = 0xbea26d68
ip   = 0xb6b1d9d0, sp   = 0xbea26d38
lr   = 0xb267e3cc, pc   = 0xb6b1d9f0
cpsr = 0x28000010

Memory Information
MemTotal:  2059708 KB
MemFree:   1589248 KB
Buffers:     17976 KB
Cached:     183932 KB
VmPeak:      89556 KB
VmSize:      89552 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       26324 KB
VmRSS:       26324 KB
VmData:      10196 KB
VmStk:         136 KB
VmExe:          32 KB
VmLib:       42372 KB
VmPTE:          78 KB
VmSwap:          0 KB

Maps Information
00008000 00010000 r-xp /usr/bin/launchpad_preloading_preinitializing_daemon
00018000 000db000 rw-p [heap]
000db000 003b7000 rw-p [heap]
b1d58000 b1d5d000 r-xp /usr/lib/libhaptic-module.so
b1d65000 b20e9000 rw-s anon_inode:exynos_gem
b20e9000 b246d000 rw-s anon_inode:exynos_gem
b263b000 b263c000 r-xp /usr/lib/libdrm_slp.so.1.0.0
b264b000 b264e000 r-xp /usr/lib/bufmgr/libtbm_exynos4412.so.0.0.0
b2656000 b2660000 r-xp /usr/lib/evas/modules/engines/software_generic/linux-gnueabi-armv7l-1.7.99/module.so
b2668000 b2671000 r-xp /usr/lib/evas/modules/engines/software_x11/linux-gnueabi-armv7l-1.7.99/module.so
b267a000 b2680000 r-xp /opt/usr/apps/kfYcpFyaST/bin/Argos1.1.exe
b2688000 b26fa000 r-xp /usr/lib/libosp-env-config.so.1.2.2.1
b2702000 b273c000 r-xp /usr/lib/libpulsecommon-0.9.23.so
b2745000 b2749000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
b2751000 b2782000 r-xp /usr/lib/libpulse.so.0.12.4
b278a000 b27ed000 r-xp /usr/lib/libasound.so.2.0.0
b27f7000 b27fa000 r-xp /usr/lib/libpulse-simple.so.0.0.3
b2802000 b2806000 r-xp /usr/lib/libascenario-0.2.so.0.0.0
b280f000 b282c000 r-xp /usr/lib/libavsysaudio.so.0.0.1
b2834000 b2842000 r-xp /usr/lib/libmmfsound.so.0.1.0
b284a000 b28e6000 r-xp /usr/lib/libgstreamer-0.10.so.0.30.0
b28f2000 b2933000 r-xp /usr/lib/libgstbase-0.10.so.0.30.0
b293c000 b2945000 r-xp /usr/lib/libgstapp-0.10.so.0.25.0
b294d000 b295a000 r-xp /usr/lib/libgstinterfaces-0.10.so.0.25.0
b2963000 b2966000 r-xp /usr/lib/libmm_ta.so.0.0.0
b296e000 b297d000 r-xp /usr/lib/libICE.so.6.3.0
b2987000 b298c000 r-xp /usr/lib/libSM.so.6.0.1
b2994000 b2995000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b299d000 b29a5000 r-xp /usr/lib/libmmfcommon.so.0.0.0
b29ad000 b29b5000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.0
b29c0000 b29c3000 r-xp /usr/lib/libmmfsession.so.0.0.0
b29cb000 b2a0f000 r-xp /usr/lib/libmmfplayer.so.0.0.0
b2a18000 b2a1e000 r-xp /usr/lib/libUMP.so
b2a26000 b2a2c000 r-xp /usr/lib/libxcb-render.so.0.0.0
b2a34000 b2a35000 r-xp /usr/lib/libxcb-shm.so.0.0.0
b2a3e000 b2a89000 r-xp /usr/lib/libtiff.so.5.1.0
b2a94000 b2abd000 r-xp /usr/lib/libturbojpeg.so
b2ad6000 b2adc000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
b2ae4000 b2aea000 r-xp /usr/lib/libgif.so.4.1.6
b2af2000 b2b14000 r-xp /usr/lib/libavutil.so.51.73.101
b2b23000 b2b51000 r-xp /usr/lib/libswscale.so.2.1.101
b2b5a000 b2e51000 r-xp /usr/lib/libavcodec.so.54.59.100
b3178000 b3191000 r-xp /usr/lib/libpng12.so.0.50.0
b319a000 b31a0000 r-xp /usr/lib/libfeedback.so.0.1.4
b31a8000 b31b4000 r-xp /usr/lib/libtts.so
b31bc000 b32f9000 r-xp /usr/lib/libMali.so
b3306000 b33bd000 r-xp /usr/lib/libcairo.so.2.11200.12
b33c7000 b33e1000 r-xp /usr/lib/osp/libosp-image-core.so.1.2.2.0
b33ea000 b3ce5000 r-xp /usr/lib/osp/libosp-uifw.so.1.2.2.1
b3d58000 b3d5d000 r-xp /usr/lib/libslp_devman_plugin.so
b3d65000 b3d68000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
b3d70000 b3d74000 r-xp /usr/lib/libsysman.so.0.2.0
b3d7c000 b3d8d000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b3d96000 b3d98000 r-xp /usr/lib/libsystemd-daemon.so.0.0.1
b3da0000 b3da2000 r-xp /usr/lib/libdeviced.so.0.1.0
b3daa000 b3dc0000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b3dc8000 b3dca000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
b3dd2000 b3dd5000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
b3ddd000 b3de0000 r-xp /usr/lib/libdevice-node.so.0.1
b3de8000 b3dec000 r-xp /usr/lib/libheynoti.so.0.0.2
b3df4000 b3e39000 r-xp /usr/lib/libsoup-2.4.so.1.5.0
b3e42000 b3e57000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b3e60000 b3e64000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
b3e6c000 b3e71000 r-xp /usr/lib/libcapi-system-system-settings.so.0.0.2
b3e79000 b3e7a000 r-xp /usr/lib/libcapi-system-power.so.0.1.1
b3e83000 b3e86000 r-xp /usr/lib/libcapi-system-device.so.0.1.0
b3e8e000 b3e91000 r-xp /usr/lib/libcapi-system-runtime-info.so.0.0.3
b3e9a000 b3e9d000 r-xp /usr/lib/libcapi-network-serial.so.0.0.8
b3ea5000 b3ea6000 r-xp /usr/lib/libcapi-content-mime-type.so.0.0.2
b3eae000 b3ebc000 r-xp /usr/lib/libcapi-appfw-application.so.0.1.0
b3ec5000 b3ee7000 r-xp /usr/lib/libSLP-tapi.so.0.0.0
b3eef000 b3ef2000 r-xp /usr/lib/libuuid.so.1.3.0
b3efb000 b3f19000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b3f21000 b3f38000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
b3f41000 b3f42000 r-xp /usr/lib/libpmapi.so.1.2
b3f4a000 b3f52000 r-xp /usr/lib/libminizip.so.1.0.0
b3f5a000 b3f65000 r-xp /usr/lib/libmessage-port.so.1.2.2.1
b3f6d000 b4045000 r-xp /usr/lib/libxml2.so.2.7.8
b4052000 b4070000 r-xp /usr/lib/libpcre.so.0.0.1
b4078000 b407b000 r-xp /usr/lib/libiniparser.so.0
b4084000 b4088000 r-xp /usr/lib/libhaptic.so.0.1
b4090000 b409b000 r-xp /usr/lib/libcryptsvc.so.0.0.1
b40a8000 b40ad000 r-xp /usr/lib/libdevman.so.0.1
b40b6000 b40ba000 r-xp /usr/lib/libchromium.so.1.0
b40c2000 b40c8000 r-xp /usr/lib/libappsvc.so.0.1.0
b40d0000 b40d1000 r-xp /usr/lib/osp/libappinfo.so.1.2.2.1
b40d9000 b40df000 r-xp /usr/lib/libalarm.so.0.0.0
b40e8000 b40f1000 r-xp /usr/lib/libcapi-security-privilege-manager.so.0.0.3
b40fa000 b410c000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.5
b4114000 b4413000 r-xp /usr/lib/osp/libosp-appfw.so.1.2.2.1
b443a000 b4444000 r-xp /lib/libnss_files-2.13.so
b444d000 b4456000 r-xp /lib/libnss_nis-2.13.so
b445f000 b4470000 r-xp /lib/libnsl-2.13.so
b447b000 b4481000 r-xp /lib/libnss_compat-2.13.so
b47a9000 b47ba000 r-xp /usr/lib/libcom-core.so.0.0.1
b47c2000 b47c4000 r-xp /usr/lib/libdri2.so.0.0.0
b47cc000 b47d4000 r-xp /usr/lib/libdrm.so.2.4.0
b47dc000 b47e0000 r-xp /usr/lib/libtbm.so.1.0.0
b47e8000 b47eb000 r-xp /usr/lib/libXv.so.1.0.0
b47f3000 b48be000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b48d4000 b48e4000 r-xp /usr/lib/libnotification.so.0.1.0
b48ec000 b48f3000 r-xp /usr/lib/libutilX.so.1.1.0
b48fb000 b491f000 r-xp /usr/lib/ecore/immodules/libisf-imf-module.so
b4928000 b4938000 r-xp /lib/libresolv-2.13.so
b493c000 b493e000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
b4946000 b4a99000 r-xp /usr/lib/libcrypto.so.1.0.0
b4ab7000 b4b03000 r-xp /usr/lib/libssl.so.1.0.0
b4b0f000 b4b3b000 r-xp /usr/lib/libidn.so.11.5.44
b4b44000 b4b4e000 r-xp /usr/lib/libcares.so.2.0.0
b4b56000 b4b6d000 r-xp /lib/libexpat.so.1.5.2
b4b77000 b4b9b000 r-xp /usr/lib/libicule.so.48.1
b4ba4000 b4bac000 r-xp /usr/lib/libsf_common.so
b4bb4000 b4c4f000 r-xp /usr/lib/libstdc++.so.6.0.14
b4c62000 b4d3f000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
b4d4a000 b4d6f000 r-xp /usr/lib/libexif.so.12.3.3
b4d83000 b4d8d000 r-xp /usr/lib/libethumb.so.1.7.99
b4d95000 b4dd9000 r-xp /usr/lib/libsndfile.so.1.0.25
b4de7000 b4de9000 r-xp /usr/lib/libctxdata.so.0.0.0
b4df1000 b4dff000 r-xp /usr/lib/libremix.so.0.0.0
b4e07000 b4e08000 r-xp /usr/lib/libecore_imf_evas.so.1.7.99
b4e10000 b4e29000 r-xp /usr/lib/liblua-5.1.so
b4e32000 b4e39000 r-xp /usr/lib/libembryo.so.1.7.99
b4e42000 b4e45000 r-xp /usr/lib/libecore_input_evas.so.1.7.99
b4e4d000 b4e8a000 r-xp /usr/lib/libcurl.so.4.3.0
b4e94000 b4e98000 r-xp /usr/lib/libecore_ipc.so.1.7.99
b4ea1000 b4f0b000 r-xp /usr/lib/libpixman-1.so.0.28.2
b4f18000 b4f3c000 r-xp /usr/lib/libfontconfig.so.1.5.0
b4f45000 b4fa1000 r-xp /usr/lib/libharfbuzz.so.0.907.0
b4fb3000 b4fc7000 r-xp /usr/lib/libfribidi.so.0.3.1
b4fcf000 b5024000 r-xp /usr/lib/libfreetype.so.6.8.1
b502f000 b5053000 r-xp /usr/lib/libjpeg.so.8.0.2
b506b000 b5082000 r-xp /lib/libz.so.1.2.5
b508a000 b5097000 r-xp /usr/lib/libsensor.so.1.1.0
b50a2000 b50a4000 r-xp /usr/lib/libapp-checker.so.0.1.0
b50ac000 b50b2000 r-xp /usr/lib/libxdgmime.so.1.1.0
b61c9000 b62b1000 r-xp /usr/lib/libicuuc.so.48.1
b62be000 b63de000 r-xp /usr/lib/libicui18n.so.48.1
b63ec000 b63ef000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b63f7000 b6400000 r-xp /usr/lib/libvconf.so.0.2.45
b6408000 b6416000 r-xp /usr/lib/libail.so.0.1.0
b641e000 b6436000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b6437000 b643c000 r-xp /usr/lib/libffi.so.5.0.10
b6444000 b6445000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
b644d000 b6457000 r-xp /usr/lib/libXext.so.6.4.0
b6460000 b6463000 r-xp /usr/lib/libXtst.so.6.1.0
b646b000 b6471000 r-xp /usr/lib/libXrender.so.1.3.0
b6479000 b647f000 r-xp /usr/lib/libXrandr.so.2.2.0
b6487000 b6488000 r-xp /usr/lib/libXinerama.so.1.0.0
b6491000 b649a000 r-xp /usr/lib/libXi.so.6.1.0
b64a2000 b64a5000 r-xp /usr/lib/libXfixes.so.3.1.0
b64ad000 b64af000 r-xp /usr/lib/libXgesture.so.7.0.0
b64b7000 b64b9000 r-xp /usr/lib/libXcomposite.so.1.0.0
b64c1000 b64c2000 r-xp /usr/lib/libXdamage.so.1.1.0
b64cb000 b64d2000 r-xp /usr/lib/libXcursor.so.1.0.2
b64da000 b64e2000 r-xp /usr/lib/libemotion.so.1.7.99
b64ea000 b6505000 r-xp /usr/lib/libecore_con.so.1.7.99
b650e000 b6513000 r-xp /usr/lib/libecore_imf.so.1.7.99
b651c000 b6524000 r-xp /usr/lib/libethumb_client.so.1.7.99
b652c000 b652e000 r-xp /usr/lib/libefreet_trash.so.1.7.99
b6536000 b653a000 r-xp /usr/lib/libefreet_mime.so.1.7.99
b6543000 b6559000 r-xp /usr/lib/libefreet.so.1.7.99
b6563000 b656c000 r-xp /usr/lib/libedbus.so.1.7.99
b6574000 b6579000 r-xp /usr/lib/libecore_fb.so.1.7.99
b6582000 b65de000 r-xp /usr/lib/libedje.so.1.7.99
b65e8000 b65ff000 r-xp /usr/lib/libecore_input.so.1.7.99
b661a000 b661f000 r-xp /usr/lib/libecore_file.so.1.7.99
b6627000 b6644000 r-xp /usr/lib/libecore_evas.so.1.7.99
b664d000 b668c000 r-xp /usr/lib/libeina.so.1.7.99
b6695000 b6744000 r-xp /usr/lib/libevas.so.1.7.99
b6766000 b6779000 r-xp /usr/lib/libeet.so.1.7.99
b6782000 b67ec000 r-xp /lib/libm-2.13.so
b67f5000 b67fa000 r-xp /usr/lib/libappcore-common.so.1.1
b6802000 b680d000 r-xp /usr/lib/libaul.so.0.1.0
b6816000 b684a000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
b6853000 b6883000 r-xp /usr/lib/libecore_x.so.1.7.99
b688c000 b68a1000 r-xp /usr/lib/libecore.so.1.7.99
b68b8000 b69d8000 r-xp /usr/lib/libelementary.so.1.7.99
b69f2000 b69f4000 r-xp /opt/usr/apps/kfYcpFyaST/bin/Argos1.1
b69fe000 b6a01000 r-xp /lib/libattr.so.1.1.0
b6a09000 b6a0b000 r-xp /usr/lib/libXau.so.6.0.0
b6a13000 b6a19000 r-xp /lib/librt-2.13.so
b6a22000 b6a2a000 r-xp /lib/libcrypt-2.13.so
b6a5a000 b6a5d000 r-xp /lib/libcap.so.2.21
b6a65000 b6a67000 r-xp /usr/lib/libiri.so
b6a6f000 b6a84000 r-xp /usr/lib/libxcb.so.1.1.0
b6a8c000 b6a97000 r-xp /lib/libunwind.so.8.0.1
b6ac5000 b6be2000 r-xp /lib/libc-2.13.so
b6bf0000 b6bf9000 r-xp /lib/libgcc_s-4.5.3.so.1
b6c01000 b6c04000 r-xp /usr/lib/libsmack.so.1.0.0
b6c0c000 b6c38000 r-xp /usr/lib/libdbus-1.so.3.7.2
b6c41000 b6c45000 r-xp /usr/lib/libbundle.so.0.1.22
b6c4d000 b6c4f000 r-xp /lib/libdl-2.13.so
b6c58000 b6d32000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
b6d3b000 b6da5000 r-xp /usr/lib/libsqlite3.so.0.8.6
b6daf000 b6dbc000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b6dc5000 b6eab000 r-xp /usr/lib/libX11.so.6.3.0
b6eb6000 b6eca000 r-xp /lib/libpthread-2.13.so
b6ed5000 b6ed6000 r-xp /usr/lib/libdlog.so.0.0.0
b6ee3000 b6ee7000 r-xp /usr/lib/libappcore-efl.so.1.1
b6ef0000 b6ef4000 r-xp /usr/lib/libsys-assert.so
b6efc000 b6f19000 r-xp /lib/ld-2.13.so
bea08000 bea29000 rwxp [stack]
End of Maps Information

Callstack Information (PID:2220)
Call Stack Count: 42
 0: fwrite + 0x20 (0xb6b1d9f0) [/lib/libc.so.6] + 0x589f0
 1: Argos1_1MainForm::OnActionPerformed(Tizen::Ui::Control const&, int) + 0x84 (0xb267e3cc) [/opt/apps/kfYcpFyaST/bin/Argos1.1.exe] + 0x43cc
 2: non-virtual thunk to Argos1_1MainForm::OnActionPerformed(Tizen::Ui::Control const&, int) + 0xc (0xb267e3f0) [/opt/apps/kfYcpFyaST/bin/Argos1.1.exe] + 0x43f0
End of Call Stack

Package Information
Package Name: kfYcpFyaST.Argos1.1
Package ID : kfYcpFyaST
Version: 1.0.0
Package Type: tpk
App Name: Argos1.1
App ID: kfYcpFyaST.Argos1.1
Type: Application
Categories: (NULL)
