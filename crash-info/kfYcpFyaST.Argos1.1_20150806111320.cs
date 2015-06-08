S/W Version Information
Model: Ref.Device-ODROID-U3
Tizen-Version: 2.2
Build-Number: Tizen_Ref.Device-ODROID-U3_20141105.1800
Build-Date: 2014.11.05 18:00:53

Crash Information
Process Name: Argos1.1
PID: 3285
Date: 2015-08-06 11:13:20(GMT+0900)
Executable File Path: /opt/apps/kfYcpFyaST/bin/Argos1.1
This process is multi-thread process
pid=3285 tid=3285
Signal: 11
      (SIGSEGV)
      si_code: -6
      signal sent by tkill (sent by pid 3285, uid 5000)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0xb6c61248, r3   = 0x00000001
r4   = 0x00000000, r5   = 0x00141f28
r6   = 0x00000000, r7   = 0x001967a0
r8   = 0xbeea0e58, r9   = 0x000acb58
r10  = 0xb44a4940, fp   = 0xbeea0d70
ip   = 0xb6b90108, sp   = 0xbeea0d48
lr   = 0xb26f24b0, pc   = 0xb6b90110
cpsr = 0x68000010

Memory Information
MemTotal:  2059708 KB
MemFree:   1550348 KB
Buffers:     22612 KB
Cached:     218796 KB
VmPeak:      89556 KB
VmSize:      89552 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       26200 KB
VmRSS:       26200 KB
VmData:      10196 KB
VmStk:         136 KB
VmExe:          32 KB
VmLib:       42372 KB
VmPTE:          76 KB
VmSwap:          0 KB

Maps Information
00008000 00010000 r-xp /usr/bin/launchpad_preloading_preinitializing_daemon
00018000 000db000 rw-p [heap]
000db000 003b7000 rw-p [heap]
b1dcc000 b1dd1000 r-xp /usr/lib/libhaptic-module.so
b1dd9000 b215d000 rw-s anon_inode:exynos_gem
b215d000 b24e1000 rw-s anon_inode:exynos_gem
b26af000 b26b0000 r-xp /usr/lib/libdrm_slp.so.1.0.0
b26bf000 b26c2000 r-xp /usr/lib/bufmgr/libtbm_exynos4412.so.0.0.0
b26ca000 b26d4000 r-xp /usr/lib/evas/modules/engines/software_generic/linux-gnueabi-armv7l-1.7.99/module.so
b26dc000 b26e5000 r-xp /usr/lib/evas/modules/engines/software_x11/linux-gnueabi-armv7l-1.7.99/module.so
b26ee000 b26f4000 r-xp /opt/usr/apps/kfYcpFyaST/bin/Argos1.1.exe
b26fc000 b276e000 r-xp /usr/lib/libosp-env-config.so.1.2.2.1
b2776000 b27b0000 r-xp /usr/lib/libpulsecommon-0.9.23.so
b27b9000 b27bd000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
b27c5000 b27f6000 r-xp /usr/lib/libpulse.so.0.12.4
b27fe000 b2861000 r-xp /usr/lib/libasound.so.2.0.0
b286b000 b286e000 r-xp /usr/lib/libpulse-simple.so.0.0.3
b2876000 b287a000 r-xp /usr/lib/libascenario-0.2.so.0.0.0
b2883000 b28a0000 r-xp /usr/lib/libavsysaudio.so.0.0.1
b28a8000 b28b6000 r-xp /usr/lib/libmmfsound.so.0.1.0
b28be000 b295a000 r-xp /usr/lib/libgstreamer-0.10.so.0.30.0
b2966000 b29a7000 r-xp /usr/lib/libgstbase-0.10.so.0.30.0
b29b0000 b29b9000 r-xp /usr/lib/libgstapp-0.10.so.0.25.0
b29c1000 b29ce000 r-xp /usr/lib/libgstinterfaces-0.10.so.0.25.0
b29d7000 b29da000 r-xp /usr/lib/libmm_ta.so.0.0.0
b29e2000 b29f1000 r-xp /usr/lib/libICE.so.6.3.0
b29fb000 b2a00000 r-xp /usr/lib/libSM.so.6.0.1
b2a08000 b2a09000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b2a11000 b2a19000 r-xp /usr/lib/libmmfcommon.so.0.0.0
b2a21000 b2a29000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.0
b2a34000 b2a37000 r-xp /usr/lib/libmmfsession.so.0.0.0
b2a3f000 b2a83000 r-xp /usr/lib/libmmfplayer.so.0.0.0
b2a8c000 b2a92000 r-xp /usr/lib/libUMP.so
b2a9a000 b2aa0000 r-xp /usr/lib/libxcb-render.so.0.0.0
b2aa8000 b2aa9000 r-xp /usr/lib/libxcb-shm.so.0.0.0
b2ab2000 b2afd000 r-xp /usr/lib/libtiff.so.5.1.0
b2b08000 b2b31000 r-xp /usr/lib/libturbojpeg.so
b2b4a000 b2b50000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
b2b58000 b2b5e000 r-xp /usr/lib/libgif.so.4.1.6
b2b66000 b2b88000 r-xp /usr/lib/libavutil.so.51.73.101
b2b97000 b2bc5000 r-xp /usr/lib/libswscale.so.2.1.101
b2bce000 b2ec5000 r-xp /usr/lib/libavcodec.so.54.59.100
b31ec000 b3205000 r-xp /usr/lib/libpng12.so.0.50.0
b320e000 b3214000 r-xp /usr/lib/libfeedback.so.0.1.4
b321c000 b3228000 r-xp /usr/lib/libtts.so
b3230000 b336d000 r-xp /usr/lib/libMali.so
b337a000 b3431000 r-xp /usr/lib/libcairo.so.2.11200.12
b343b000 b3455000 r-xp /usr/lib/osp/libosp-image-core.so.1.2.2.0
b345e000 b3d59000 r-xp /usr/lib/osp/libosp-uifw.so.1.2.2.1
b3dcc000 b3dd1000 r-xp /usr/lib/libslp_devman_plugin.so
b3dd9000 b3ddc000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
b3de4000 b3de8000 r-xp /usr/lib/libsysman.so.0.2.0
b3df0000 b3e01000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b3e0a000 b3e0c000 r-xp /usr/lib/libsystemd-daemon.so.0.0.1
b3e14000 b3e16000 r-xp /usr/lib/libdeviced.so.0.1.0
b3e1e000 b3e34000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b3e3c000 b3e3e000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
b3e46000 b3e49000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
b3e51000 b3e54000 r-xp /usr/lib/libdevice-node.so.0.1
b3e5c000 b3e60000 r-xp /usr/lib/libheynoti.so.0.0.2
b3e68000 b3ead000 r-xp /usr/lib/libsoup-2.4.so.1.5.0
b3eb6000 b3ecb000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b3ed4000 b3ed8000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
b3ee0000 b3ee5000 r-xp /usr/lib/libcapi-system-system-settings.so.0.0.2
b3eed000 b3eee000 r-xp /usr/lib/libcapi-system-power.so.0.1.1
b3ef7000 b3efa000 r-xp /usr/lib/libcapi-system-device.so.0.1.0
b3f02000 b3f05000 r-xp /usr/lib/libcapi-system-runtime-info.so.0.0.3
b3f0e000 b3f11000 r-xp /usr/lib/libcapi-network-serial.so.0.0.8
b3f19000 b3f1a000 r-xp /usr/lib/libcapi-content-mime-type.so.0.0.2
b3f22000 b3f30000 r-xp /usr/lib/libcapi-appfw-application.so.0.1.0
b3f39000 b3f5b000 r-xp /usr/lib/libSLP-tapi.so.0.0.0
b3f63000 b3f66000 r-xp /usr/lib/libuuid.so.1.3.0
b3f6f000 b3f8d000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b3f95000 b3fac000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
b3fb5000 b3fb6000 r-xp /usr/lib/libpmapi.so.1.2
b3fbe000 b3fc6000 r-xp /usr/lib/libminizip.so.1.0.0
b3fce000 b3fd9000 r-xp /usr/lib/libmessage-port.so.1.2.2.1
b3fe1000 b40b9000 r-xp /usr/lib/libxml2.so.2.7.8
b40c6000 b40e4000 r-xp /usr/lib/libpcre.so.0.0.1
b40ec000 b40ef000 r-xp /usr/lib/libiniparser.so.0
b40f8000 b40fc000 r-xp /usr/lib/libhaptic.so.0.1
b4104000 b410f000 r-xp /usr/lib/libcryptsvc.so.0.0.1
b411c000 b4121000 r-xp /usr/lib/libdevman.so.0.1
b412a000 b412e000 r-xp /usr/lib/libchromium.so.1.0
b4136000 b413c000 r-xp /usr/lib/libappsvc.so.0.1.0
b4144000 b4145000 r-xp /usr/lib/osp/libappinfo.so.1.2.2.1
b414d000 b4153000 r-xp /usr/lib/libalarm.so.0.0.0
b415c000 b4165000 r-xp /usr/lib/libcapi-security-privilege-manager.so.0.0.3
b416e000 b4180000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.5
b4188000 b4487000 r-xp /usr/lib/osp/libosp-appfw.so.1.2.2.1
b44ae000 b44b8000 r-xp /lib/libnss_files-2.13.so
b44c1000 b44ca000 r-xp /lib/libnss_nis-2.13.so
b44d3000 b44e4000 r-xp /lib/libnsl-2.13.so
b44ef000 b44f5000 r-xp /lib/libnss_compat-2.13.so
b481d000 b482e000 r-xp /usr/lib/libcom-core.so.0.0.1
b4836000 b4838000 r-xp /usr/lib/libdri2.so.0.0.0
b4840000 b4848000 r-xp /usr/lib/libdrm.so.2.4.0
b4850000 b4854000 r-xp /usr/lib/libtbm.so.1.0.0
b485c000 b485f000 r-xp /usr/lib/libXv.so.1.0.0
b4867000 b4932000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b4948000 b4958000 r-xp /usr/lib/libnotification.so.0.1.0
b4960000 b4967000 r-xp /usr/lib/libutilX.so.1.1.0
b496f000 b4993000 r-xp /usr/lib/ecore/immodules/libisf-imf-module.so
b499c000 b49ac000 r-xp /lib/libresolv-2.13.so
b49b0000 b49b2000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
b49ba000 b4b0d000 r-xp /usr/lib/libcrypto.so.1.0.0
b4b2b000 b4b77000 r-xp /usr/lib/libssl.so.1.0.0
b4b83000 b4baf000 r-xp /usr/lib/libidn.so.11.5.44
b4bb8000 b4bc2000 r-xp /usr/lib/libcares.so.2.0.0
b4bca000 b4be1000 r-xp /lib/libexpat.so.1.5.2
b4beb000 b4c0f000 r-xp /usr/lib/libicule.so.48.1
b4c18000 b4c20000 r-xp /usr/lib/libsf_common.so
b4c28000 b4cc3000 r-xp /usr/lib/libstdc++.so.6.0.14
b4cd6000 b4db3000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
b4dbe000 b4de3000 r-xp /usr/lib/libexif.so.12.3.3
b4df7000 b4e01000 r-xp /usr/lib/libethumb.so.1.7.99
b4e09000 b4e4d000 r-xp /usr/lib/libsndfile.so.1.0.25
b4e5b000 b4e5d000 r-xp /usr/lib/libctxdata.so.0.0.0
b4e65000 b4e73000 r-xp /usr/lib/libremix.so.0.0.0
b4e7b000 b4e7c000 r-xp /usr/lib/libecore_imf_evas.so.1.7.99
b4e84000 b4e9d000 r-xp /usr/lib/liblua-5.1.so
b4ea6000 b4ead000 r-xp /usr/lib/libembryo.so.1.7.99
b4eb6000 b4eb9000 r-xp /usr/lib/libecore_input_evas.so.1.7.99
b4ec1000 b4efe000 r-xp /usr/lib/libcurl.so.4.3.0
b4f08000 b4f0c000 r-xp /usr/lib/libecore_ipc.so.1.7.99
b4f15000 b4f7f000 r-xp /usr/lib/libpixman-1.so.0.28.2
b4f8c000 b4fb0000 r-xp /usr/lib/libfontconfig.so.1.5.0
b4fb9000 b5015000 r-xp /usr/lib/libharfbuzz.so.0.907.0
b5027000 b503b000 r-xp /usr/lib/libfribidi.so.0.3.1
b5043000 b5098000 r-xp /usr/lib/libfreetype.so.6.8.1
b50a3000 b50c7000 r-xp /usr/lib/libjpeg.so.8.0.2
b50df000 b50f6000 r-xp /lib/libz.so.1.2.5
b50fe000 b510b000 r-xp /usr/lib/libsensor.so.1.1.0
b5116000 b5118000 r-xp /usr/lib/libapp-checker.so.0.1.0
b5120000 b5126000 r-xp /usr/lib/libxdgmime.so.1.1.0
b623d000 b6325000 r-xp /usr/lib/libicuuc.so.48.1
b6332000 b6452000 r-xp /usr/lib/libicui18n.so.48.1
b6460000 b6463000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b646b000 b6474000 r-xp /usr/lib/libvconf.so.0.2.45
b647c000 b648a000 r-xp /usr/lib/libail.so.0.1.0
b6492000 b64aa000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b64ab000 b64b0000 r-xp /usr/lib/libffi.so.5.0.10
b64b8000 b64b9000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
b64c1000 b64cb000 r-xp /usr/lib/libXext.so.6.4.0
b64d4000 b64d7000 r-xp /usr/lib/libXtst.so.6.1.0
b64df000 b64e5000 r-xp /usr/lib/libXrender.so.1.3.0
b64ed000 b64f3000 r-xp /usr/lib/libXrandr.so.2.2.0
b64fb000 b64fc000 r-xp /usr/lib/libXinerama.so.1.0.0
b6505000 b650e000 r-xp /usr/lib/libXi.so.6.1.0
b6516000 b6519000 r-xp /usr/lib/libXfixes.so.3.1.0
b6521000 b6523000 r-xp /usr/lib/libXgesture.so.7.0.0
b652b000 b652d000 r-xp /usr/lib/libXcomposite.so.1.0.0
b6535000 b6536000 r-xp /usr/lib/libXdamage.so.1.1.0
b653f000 b6546000 r-xp /usr/lib/libXcursor.so.1.0.2
b654e000 b6556000 r-xp /usr/lib/libemotion.so.1.7.99
b655e000 b6579000 r-xp /usr/lib/libecore_con.so.1.7.99
b6582000 b6587000 r-xp /usr/lib/libecore_imf.so.1.7.99
b6590000 b6598000 r-xp /usr/lib/libethumb_client.so.1.7.99
b65a0000 b65a2000 r-xp /usr/lib/libefreet_trash.so.1.7.99
b65aa000 b65ae000 r-xp /usr/lib/libefreet_mime.so.1.7.99
b65b7000 b65cd000 r-xp /usr/lib/libefreet.so.1.7.99
b65d7000 b65e0000 r-xp /usr/lib/libedbus.so.1.7.99
b65e8000 b65ed000 r-xp /usr/lib/libecore_fb.so.1.7.99
b65f6000 b6652000 r-xp /usr/lib/libedje.so.1.7.99
b665c000 b6673000 r-xp /usr/lib/libecore_input.so.1.7.99
b668e000 b6693000 r-xp /usr/lib/libecore_file.so.1.7.99
b669b000 b66b8000 r-xp /usr/lib/libecore_evas.so.1.7.99
b66c1000 b6700000 r-xp /usr/lib/libeina.so.1.7.99
b6709000 b67b8000 r-xp /usr/lib/libevas.so.1.7.99
b67da000 b67ed000 r-xp /usr/lib/libeet.so.1.7.99
b67f6000 b6860000 r-xp /lib/libm-2.13.so
b6869000 b686e000 r-xp /usr/lib/libappcore-common.so.1.1
b6876000 b6881000 r-xp /usr/lib/libaul.so.0.1.0
b688a000 b68be000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
b68c7000 b68f7000 r-xp /usr/lib/libecore_x.so.1.7.99
b6900000 b6915000 r-xp /usr/lib/libecore.so.1.7.99
b692c000 b6a4c000 r-xp /usr/lib/libelementary.so.1.7.99
b6a66000 b6a68000 r-xp /opt/usr/apps/kfYcpFyaST/bin/Argos1.1
b6a72000 b6a75000 r-xp /lib/libattr.so.1.1.0
b6a7d000 b6a7f000 r-xp /usr/lib/libXau.so.6.0.0
b6a87000 b6a8d000 r-xp /lib/librt-2.13.so
b6a96000 b6a9e000 r-xp /lib/libcrypt-2.13.so
b6ace000 b6ad1000 r-xp /lib/libcap.so.2.21
b6ad9000 b6adb000 r-xp /usr/lib/libiri.so
b6ae3000 b6af8000 r-xp /usr/lib/libxcb.so.1.1.0
b6b00000 b6b0b000 r-xp /lib/libunwind.so.8.0.1
b6b39000 b6c56000 r-xp /lib/libc-2.13.so
b6c64000 b6c6d000 r-xp /lib/libgcc_s-4.5.3.so.1
b6c75000 b6c78000 r-xp /usr/lib/libsmack.so.1.0.0
b6c80000 b6cac000 r-xp /usr/lib/libdbus-1.so.3.7.2
b6cb5000 b6cb9000 r-xp /usr/lib/libbundle.so.0.1.22
b6cc1000 b6cc3000 r-xp /lib/libdl-2.13.so
b6ccc000 b6da6000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
b6daf000 b6e19000 r-xp /usr/lib/libsqlite3.so.0.8.6
b6e23000 b6e30000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b6e39000 b6f1f000 r-xp /usr/lib/libX11.so.6.3.0
b6f2a000 b6f3e000 r-xp /lib/libpthread-2.13.so
b6f49000 b6f4a000 r-xp /usr/lib/libdlog.so.0.0.0
b6f57000 b6f5b000 r-xp /usr/lib/libappcore-efl.so.1.1
b6f64000 b6f68000 r-xp /usr/lib/libsys-assert.so
b6f70000 b6f8d000 r-xp /lib/ld-2.13.so
bee82000 beea3000 rwxp [stack]
End of Maps Information

Callstack Information (PID:3285)
Call Stack Count: 41
 0: fclose + 0x8 (0xb6b90110) [/lib/libc.so.6] + 0x57110
 1: non-virtual thunk to Argos1_1MainForm::OnActionPerformed(Tizen::Ui::Control const&, int) + 0x84 (0xb26f24b0) [/opt/apps/kfYcpFyaST/bin/Argos1.1.exe] + 0x44b0
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
