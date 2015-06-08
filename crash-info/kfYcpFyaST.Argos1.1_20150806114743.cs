S/W Version Information
Model: Ref.Device-ODROID-U3
Tizen-Version: 2.2
Build-Number: Tizen_Ref.Device-ODROID-U3_20141105.1800
Build-Date: 2014.11.05 18:00:53

Crash Information
Process Name: Argos1.1
PID: 2504
Date: 2015-08-06 11:47:43(GMT+0900)
Executable File Path: /opt/apps/kfYcpFyaST/bin/Argos1.1
This process is multi-thread process
pid=2504 tid=2504
Signal: 11
      (SIGSEGV)
      si_code: -6
      signal sent by tkill (sent by pid 2504, uid 5000)

Register Information
r0   = 0x00000065, r1   = 0x00177ad0
r2   = 0x00000065, r3   = 0xb26a6674
r4   = 0x00000065, r5   = 0x00141f00
r6   = 0x00000065, r7   = 0x001bbb40
r8   = 0xbecaae58, r9   = 0x000acb48
r10  = 0xb444f940, fp   = 0xbecaad68
ip   = 0xb6b3b108, sp   = 0xbecaad40
lr   = 0xb269d420, pc   = 0xb6b3b110
cpsr = 0x68000010

Memory Information
MemTotal:  2059708 KB
MemFree:   1601600 KB
Buffers:     20116 KB
Cached:     172420 KB
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
b1d77000 b1d7c000 r-xp /usr/lib/libhaptic-module.so
b1d84000 b2108000 rw-s anon_inode:exynos_gem
b2108000 b248c000 rw-s anon_inode:exynos_gem
b265a000 b265b000 r-xp /usr/lib/libdrm_slp.so.1.0.0
b266a000 b266d000 r-xp /usr/lib/bufmgr/libtbm_exynos4412.so.0.0.0
b2675000 b267f000 r-xp /usr/lib/evas/modules/engines/software_generic/linux-gnueabi-armv7l-1.7.99/module.so
b2687000 b2690000 r-xp /usr/lib/evas/modules/engines/software_x11/linux-gnueabi-armv7l-1.7.99/module.so
b2699000 b269f000 r-xp /opt/usr/apps/kfYcpFyaST/bin/Argos1.1.exe
b26a7000 b2719000 r-xp /usr/lib/libosp-env-config.so.1.2.2.1
b2721000 b275b000 r-xp /usr/lib/libpulsecommon-0.9.23.so
b2764000 b2768000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
b2770000 b27a1000 r-xp /usr/lib/libpulse.so.0.12.4
b27a9000 b280c000 r-xp /usr/lib/libasound.so.2.0.0
b2816000 b2819000 r-xp /usr/lib/libpulse-simple.so.0.0.3
b2821000 b2825000 r-xp /usr/lib/libascenario-0.2.so.0.0.0
b282e000 b284b000 r-xp /usr/lib/libavsysaudio.so.0.0.1
b2853000 b2861000 r-xp /usr/lib/libmmfsound.so.0.1.0
b2869000 b2905000 r-xp /usr/lib/libgstreamer-0.10.so.0.30.0
b2911000 b2952000 r-xp /usr/lib/libgstbase-0.10.so.0.30.0
b295b000 b2964000 r-xp /usr/lib/libgstapp-0.10.so.0.25.0
b296c000 b2979000 r-xp /usr/lib/libgstinterfaces-0.10.so.0.25.0
b2982000 b2985000 r-xp /usr/lib/libmm_ta.so.0.0.0
b298d000 b299c000 r-xp /usr/lib/libICE.so.6.3.0
b29a6000 b29ab000 r-xp /usr/lib/libSM.so.6.0.1
b29b3000 b29b4000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b29bc000 b29c4000 r-xp /usr/lib/libmmfcommon.so.0.0.0
b29cc000 b29d4000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.0
b29df000 b29e2000 r-xp /usr/lib/libmmfsession.so.0.0.0
b29ea000 b2a2e000 r-xp /usr/lib/libmmfplayer.so.0.0.0
b2a37000 b2a3d000 r-xp /usr/lib/libUMP.so
b2a45000 b2a4b000 r-xp /usr/lib/libxcb-render.so.0.0.0
b2a53000 b2a54000 r-xp /usr/lib/libxcb-shm.so.0.0.0
b2a5d000 b2aa8000 r-xp /usr/lib/libtiff.so.5.1.0
b2ab3000 b2adc000 r-xp /usr/lib/libturbojpeg.so
b2af5000 b2afb000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
b2b03000 b2b09000 r-xp /usr/lib/libgif.so.4.1.6
b2b11000 b2b33000 r-xp /usr/lib/libavutil.so.51.73.101
b2b42000 b2b70000 r-xp /usr/lib/libswscale.so.2.1.101
b2b79000 b2e70000 r-xp /usr/lib/libavcodec.so.54.59.100
b3197000 b31b0000 r-xp /usr/lib/libpng12.so.0.50.0
b31b9000 b31bf000 r-xp /usr/lib/libfeedback.so.0.1.4
b31c7000 b31d3000 r-xp /usr/lib/libtts.so
b31db000 b3318000 r-xp /usr/lib/libMali.so
b3325000 b33dc000 r-xp /usr/lib/libcairo.so.2.11200.12
b33e6000 b3400000 r-xp /usr/lib/osp/libosp-image-core.so.1.2.2.0
b3409000 b3d04000 r-xp /usr/lib/osp/libosp-uifw.so.1.2.2.1
b3d77000 b3d7c000 r-xp /usr/lib/libslp_devman_plugin.so
b3d84000 b3d87000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
b3d8f000 b3d93000 r-xp /usr/lib/libsysman.so.0.2.0
b3d9b000 b3dac000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b3db5000 b3db7000 r-xp /usr/lib/libsystemd-daemon.so.0.0.1
b3dbf000 b3dc1000 r-xp /usr/lib/libdeviced.so.0.1.0
b3dc9000 b3ddf000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b3de7000 b3de9000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
b3df1000 b3df4000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
b3dfc000 b3dff000 r-xp /usr/lib/libdevice-node.so.0.1
b3e07000 b3e0b000 r-xp /usr/lib/libheynoti.so.0.0.2
b3e13000 b3e58000 r-xp /usr/lib/libsoup-2.4.so.1.5.0
b3e61000 b3e76000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b3e7f000 b3e83000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
b3e8b000 b3e90000 r-xp /usr/lib/libcapi-system-system-settings.so.0.0.2
b3e98000 b3e99000 r-xp /usr/lib/libcapi-system-power.so.0.1.1
b3ea2000 b3ea5000 r-xp /usr/lib/libcapi-system-device.so.0.1.0
b3ead000 b3eb0000 r-xp /usr/lib/libcapi-system-runtime-info.so.0.0.3
b3eb9000 b3ebc000 r-xp /usr/lib/libcapi-network-serial.so.0.0.8
b3ec4000 b3ec5000 r-xp /usr/lib/libcapi-content-mime-type.so.0.0.2
b3ecd000 b3edb000 r-xp /usr/lib/libcapi-appfw-application.so.0.1.0
b3ee4000 b3f06000 r-xp /usr/lib/libSLP-tapi.so.0.0.0
b3f0e000 b3f11000 r-xp /usr/lib/libuuid.so.1.3.0
b3f1a000 b3f38000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b3f40000 b3f57000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
b3f60000 b3f61000 r-xp /usr/lib/libpmapi.so.1.2
b3f69000 b3f71000 r-xp /usr/lib/libminizip.so.1.0.0
b3f79000 b3f84000 r-xp /usr/lib/libmessage-port.so.1.2.2.1
b3f8c000 b4064000 r-xp /usr/lib/libxml2.so.2.7.8
b4071000 b408f000 r-xp /usr/lib/libpcre.so.0.0.1
b4097000 b409a000 r-xp /usr/lib/libiniparser.so.0
b40a3000 b40a7000 r-xp /usr/lib/libhaptic.so.0.1
b40af000 b40ba000 r-xp /usr/lib/libcryptsvc.so.0.0.1
b40c7000 b40cc000 r-xp /usr/lib/libdevman.so.0.1
b40d5000 b40d9000 r-xp /usr/lib/libchromium.so.1.0
b40e1000 b40e7000 r-xp /usr/lib/libappsvc.so.0.1.0
b40ef000 b40f0000 r-xp /usr/lib/osp/libappinfo.so.1.2.2.1
b40f8000 b40fe000 r-xp /usr/lib/libalarm.so.0.0.0
b4107000 b4110000 r-xp /usr/lib/libcapi-security-privilege-manager.so.0.0.3
b4119000 b412b000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.5
b4133000 b4432000 r-xp /usr/lib/osp/libosp-appfw.so.1.2.2.1
b4459000 b4463000 r-xp /lib/libnss_files-2.13.so
b446c000 b4475000 r-xp /lib/libnss_nis-2.13.so
b447e000 b448f000 r-xp /lib/libnsl-2.13.so
b449a000 b44a0000 r-xp /lib/libnss_compat-2.13.so
b47c8000 b47d9000 r-xp /usr/lib/libcom-core.so.0.0.1
b47e1000 b47e3000 r-xp /usr/lib/libdri2.so.0.0.0
b47eb000 b47f3000 r-xp /usr/lib/libdrm.so.2.4.0
b47fb000 b47ff000 r-xp /usr/lib/libtbm.so.1.0.0
b4807000 b480a000 r-xp /usr/lib/libXv.so.1.0.0
b4812000 b48dd000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b48f3000 b4903000 r-xp /usr/lib/libnotification.so.0.1.0
b490b000 b4912000 r-xp /usr/lib/libutilX.so.1.1.0
b491a000 b493e000 r-xp /usr/lib/ecore/immodules/libisf-imf-module.so
b4947000 b4957000 r-xp /lib/libresolv-2.13.so
b495b000 b495d000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
b4965000 b4ab8000 r-xp /usr/lib/libcrypto.so.1.0.0
b4ad6000 b4b22000 r-xp /usr/lib/libssl.so.1.0.0
b4b2e000 b4b5a000 r-xp /usr/lib/libidn.so.11.5.44
b4b63000 b4b6d000 r-xp /usr/lib/libcares.so.2.0.0
b4b75000 b4b8c000 r-xp /lib/libexpat.so.1.5.2
b4b96000 b4bba000 r-xp /usr/lib/libicule.so.48.1
b4bc3000 b4bcb000 r-xp /usr/lib/libsf_common.so
b4bd3000 b4c6e000 r-xp /usr/lib/libstdc++.so.6.0.14
b4c81000 b4d5e000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
b4d69000 b4d8e000 r-xp /usr/lib/libexif.so.12.3.3
b4da2000 b4dac000 r-xp /usr/lib/libethumb.so.1.7.99
b4db4000 b4df8000 r-xp /usr/lib/libsndfile.so.1.0.25
b4e06000 b4e08000 r-xp /usr/lib/libctxdata.so.0.0.0
b4e10000 b4e1e000 r-xp /usr/lib/libremix.so.0.0.0
b4e26000 b4e27000 r-xp /usr/lib/libecore_imf_evas.so.1.7.99
b4e2f000 b4e48000 r-xp /usr/lib/liblua-5.1.so
b4e51000 b4e58000 r-xp /usr/lib/libembryo.so.1.7.99
b4e61000 b4e64000 r-xp /usr/lib/libecore_input_evas.so.1.7.99
b4e6c000 b4ea9000 r-xp /usr/lib/libcurl.so.4.3.0
b4eb3000 b4eb7000 r-xp /usr/lib/libecore_ipc.so.1.7.99
b4ec0000 b4f2a000 r-xp /usr/lib/libpixman-1.so.0.28.2
b4f37000 b4f5b000 r-xp /usr/lib/libfontconfig.so.1.5.0
b4f64000 b4fc0000 r-xp /usr/lib/libharfbuzz.so.0.907.0
b4fd2000 b4fe6000 r-xp /usr/lib/libfribidi.so.0.3.1
b4fee000 b5043000 r-xp /usr/lib/libfreetype.so.6.8.1
b504e000 b5072000 r-xp /usr/lib/libjpeg.so.8.0.2
b508a000 b50a1000 r-xp /lib/libz.so.1.2.5
b50a9000 b50b6000 r-xp /usr/lib/libsensor.so.1.1.0
b50c1000 b50c3000 r-xp /usr/lib/libapp-checker.so.0.1.0
b50cb000 b50d1000 r-xp /usr/lib/libxdgmime.so.1.1.0
b61e8000 b62d0000 r-xp /usr/lib/libicuuc.so.48.1
b62dd000 b63fd000 r-xp /usr/lib/libicui18n.so.48.1
b640b000 b640e000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b6416000 b641f000 r-xp /usr/lib/libvconf.so.0.2.45
b6427000 b6435000 r-xp /usr/lib/libail.so.0.1.0
b643d000 b6455000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b6456000 b645b000 r-xp /usr/lib/libffi.so.5.0.10
b6463000 b6464000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
b646c000 b6476000 r-xp /usr/lib/libXext.so.6.4.0
b647f000 b6482000 r-xp /usr/lib/libXtst.so.6.1.0
b648a000 b6490000 r-xp /usr/lib/libXrender.so.1.3.0
b6498000 b649e000 r-xp /usr/lib/libXrandr.so.2.2.0
b64a6000 b64a7000 r-xp /usr/lib/libXinerama.so.1.0.0
b64b0000 b64b9000 r-xp /usr/lib/libXi.so.6.1.0
b64c1000 b64c4000 r-xp /usr/lib/libXfixes.so.3.1.0
b64cc000 b64ce000 r-xp /usr/lib/libXgesture.so.7.0.0
b64d6000 b64d8000 r-xp /usr/lib/libXcomposite.so.1.0.0
b64e0000 b64e1000 r-xp /usr/lib/libXdamage.so.1.1.0
b64ea000 b64f1000 r-xp /usr/lib/libXcursor.so.1.0.2
b64f9000 b6501000 r-xp /usr/lib/libemotion.so.1.7.99
b6509000 b6524000 r-xp /usr/lib/libecore_con.so.1.7.99
b652d000 b6532000 r-xp /usr/lib/libecore_imf.so.1.7.99
b653b000 b6543000 r-xp /usr/lib/libethumb_client.so.1.7.99
b654b000 b654d000 r-xp /usr/lib/libefreet_trash.so.1.7.99
b6555000 b6559000 r-xp /usr/lib/libefreet_mime.so.1.7.99
b6562000 b6578000 r-xp /usr/lib/libefreet.so.1.7.99
b6582000 b658b000 r-xp /usr/lib/libedbus.so.1.7.99
b6593000 b6598000 r-xp /usr/lib/libecore_fb.so.1.7.99
b65a1000 b65fd000 r-xp /usr/lib/libedje.so.1.7.99
b6607000 b661e000 r-xp /usr/lib/libecore_input.so.1.7.99
b6639000 b663e000 r-xp /usr/lib/libecore_file.so.1.7.99
b6646000 b6663000 r-xp /usr/lib/libecore_evas.so.1.7.99
b666c000 b66ab000 r-xp /usr/lib/libeina.so.1.7.99
b66b4000 b6763000 r-xp /usr/lib/libevas.so.1.7.99
b6785000 b6798000 r-xp /usr/lib/libeet.so.1.7.99
b67a1000 b680b000 r-xp /lib/libm-2.13.so
b6814000 b6819000 r-xp /usr/lib/libappcore-common.so.1.1
b6821000 b682c000 r-xp /usr/lib/libaul.so.0.1.0
b6835000 b6869000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
b6872000 b68a2000 r-xp /usr/lib/libecore_x.so.1.7.99
b68ab000 b68c0000 r-xp /usr/lib/libecore.so.1.7.99
b68d7000 b69f7000 r-xp /usr/lib/libelementary.so.1.7.99
b6a11000 b6a13000 r-xp /opt/usr/apps/kfYcpFyaST/bin/Argos1.1
b6a1d000 b6a20000 r-xp /lib/libattr.so.1.1.0
b6a28000 b6a2a000 r-xp /usr/lib/libXau.so.6.0.0
b6a32000 b6a38000 r-xp /lib/librt-2.13.so
b6a41000 b6a49000 r-xp /lib/libcrypt-2.13.so
b6a79000 b6a7c000 r-xp /lib/libcap.so.2.21
b6a84000 b6a86000 r-xp /usr/lib/libiri.so
b6a8e000 b6aa3000 r-xp /usr/lib/libxcb.so.1.1.0
b6aab000 b6ab6000 r-xp /lib/libunwind.so.8.0.1
b6ae4000 b6c01000 r-xp /lib/libc-2.13.so
b6c0f000 b6c18000 r-xp /lib/libgcc_s-4.5.3.so.1
b6c20000 b6c23000 r-xp /usr/lib/libsmack.so.1.0.0
b6c2b000 b6c57000 r-xp /usr/lib/libdbus-1.so.3.7.2
b6c60000 b6c64000 r-xp /usr/lib/libbundle.so.0.1.22
b6c6c000 b6c6e000 r-xp /lib/libdl-2.13.so
b6c77000 b6d51000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
b6d5a000 b6dc4000 r-xp /usr/lib/libsqlite3.so.0.8.6
b6dce000 b6ddb000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b6de4000 b6eca000 r-xp /usr/lib/libX11.so.6.3.0
b6ed5000 b6ee9000 r-xp /lib/libpthread-2.13.so
b6ef4000 b6ef5000 r-xp /usr/lib/libdlog.so.0.0.0
b6f02000 b6f06000 r-xp /usr/lib/libappcore-efl.so.1.1
b6f0f000 b6f13000 r-xp /usr/lib/libsys-assert.so
b6f1b000 b6f38000 r-xp /lib/ld-2.13.so
bec8c000 becad000 rwxp [stack]
End of Maps Information

Callstack Information (PID:2504)
Call Stack Count: 42
 0: fclose + 0x8 (0xb6b3b110) [/lib/libc.so.6] + 0x57110
 1: Argos1_1MainForm::OnActionPerformed(Tizen::Ui::Control const&, int) + 0x90 (0xb269d420) [/opt/apps/kfYcpFyaST/bin/Argos1.1.exe] + 0x4420
 2: non-virtual thunk to Argos1_1MainForm::OnActionPerformed(Tizen::Ui::Control const&, int) + 0xc (0xb269d444) [/opt/apps/kfYcpFyaST/bin/Argos1.1.exe] + 0x4444
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
