S/W Version Information
Model: Ref.Device-ODROID-U3
Tizen-Version: 2.2
Build-Number: Tizen_Ref.Device-ODROID-U3_20141105.1800
Build-Date: 2014.11.05 18:00:53

Crash Information
Process Name: Argos1.1
PID: 3000
Date: 2015-08-06 17:41:47(GMT+0900)
Executable File Path: /opt/apps/kfYcpFyaST/bin/Argos1.1
This process is multi-thread process
pid=3000 tid=3000
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0xb6266248, r3   = 0x00000001
r4   = 0x00000066, r5   = 0x2a0fc248
r6   = 0x00000000, r7   = 0x2a175cf8
r8   = 0xbeffcce8, r9   = 0x2a06f2e8
r10  = 0xb6644940, fp   = 0xbeffcc00
ip   = 0xb6195108, sp   = 0xbeffcbd8
lr   = 0x2a004498, pc   = 0xb6195110
cpsr = 0x68000010

Memory Information
MemTotal:  2059708 KB
MemFree:   1554560 KB
Buffers:     23220 KB
Cached:     209244 KB
VmPeak:      90872 KB
VmSize:      90868 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       34140 KB
VmRSS:       34140 KB
VmData:      12104 KB
VmStk:         136 KB
VmExe:          24 KB
VmLib:       62952 KB
VmPTE:          78 KB
VmSwap:          0 KB

Maps Information
2a000000 2a006000 r-xp /opt/usr/apps/kfYcpFyaST/bin/Argos1.1.exe
2a00d000 2a00e000 rwxp /opt/usr/apps/kfYcpFyaST/bin/Argos1.1.exe
2a00e000 2a372000 rwxp [heap]
b1ea9000 b1eae000 r-xp /usr/lib/libhaptic-module.so
b1eb5000 b1eb6000 rwxp /usr/lib/libhaptic-module.so
b1eb6000 b223a000 rwxs anon_inode:exynos_gem
b223a000 b25be000 rwxs anon_inode:exynos_gem
b25be000 b2609000 rwxs /dev/shm/elm_indicator_portrait-0-946688430.1079.78380445
b2609000 b2634000 rwxs /dev/shm/elm_indicator_landscape-0-946688430.1079.229766994
b2634000 b267f000 rwxs /dev/shm/elm_indicator_portrait-0-946688430.1079.78380445
b267f000 b26aa000 rwxs /dev/shm/elm_indicator_landscape-0-946688430.1079.229766994
b273a000 b275f000 r-xp /usr/share/fonts/TizenSansMedium.ttf
b275f000 b2784000 r-xp /usr/share/fonts/TizenSansRegular.ttf
b2784000 b278c000 r-xs /var/cache/fontconfig/cdc77cde135ce87b641818a103cc9edb-le32d8.cache-3
b278c000 b278f000 r-xp /usr/lib/bufmgr/libtbm_exynos4412.so.0.0.0
b2796000 b2797000 rwxp /usr/lib/bufmgr/libtbm_exynos4412.so.0.0.0
b2797000 b27a1000 r-xp /usr/lib/evas/modules/engines/software_generic/linux-gnueabi-armv7l-1.7.99/module.so
b27a8000 b27a9000 rwxp /usr/lib/evas/modules/engines/software_generic/linux-gnueabi-armv7l-1.7.99/module.so
b27a9000 b27b2000 r-xp /usr/lib/evas/modules/engines/software_x11/linux-gnueabi-armv7l-1.7.99/module.so
b27ba000 b27bb000 rwxp /usr/lib/evas/modules/engines/software_x11/linux-gnueabi-armv7l-1.7.99/module.so
b27bb000 b27c5000 r-xp /lib/libnss_files-2.13.so
b27cc000 b27cd000 r-xp /lib/libnss_files-2.13.so
b27cd000 b27ce000 rwxp /lib/libnss_files-2.13.so
b27ce000 b27d7000 r-xp /lib/libnss_nis-2.13.so
b27de000 b27df000 r-xp /lib/libnss_nis-2.13.so
b27df000 b27e0000 rwxp /lib/libnss_nis-2.13.so
b27e0000 b27f1000 r-xp /lib/libnsl-2.13.so
b27f8000 b27f9000 r-xp /lib/libnsl-2.13.so
b27f9000 b27fa000 rwxp /lib/libnsl-2.13.so
b27fc000 b2802000 r-xp /lib/libnss_compat-2.13.so
b2809000 b280a000 r-xp /lib/libnss_compat-2.13.so
b280a000 b280b000 rwxp /lib/libnss_compat-2.13.so
b280b000 b28d6000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b28de000 b28ec000 rwxp /usr/lib/libscim-1.0.so.8.2.3
b28ee000 b28ef000 r-xp /usr/lib/libdrm_slp.so.1.0.0
b28f6000 b28f7000 rwxp /usr/lib/libdrm_slp.so.1.0.0
b28f7000 b28fe000 r-xs /usr/lib/gconv/gconv-modules.cache
b28fe000 b2922000 r-xp /usr/lib/ecore/immodules/libisf-imf-module.so
b2929000 b292b000 rwxp /usr/lib/ecore/immodules/libisf-imf-module.so
b292b000 b2a4a000 r-xp /usr/lib/locale/locale-archive
b2a4a000 b2c4a000 r-xp /usr/lib/locale/locale-archive
b2c51000 b2c8b000 r-xp /usr/lib/libpulsecommon-0.9.23.so
b2c93000 b2c94000 rwxp /usr/lib/libpulsecommon-0.9.23.so
b2c95000 b2c99000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
b2ca0000 b2ca1000 rwxp /usr/lib/libmmfsoundcommon.so.0.0.0
b2ca1000 b2ca4000 r-xp /lib/libattr.so.1.1.0
b2cab000 b2cac000 rwxp /lib/libattr.so.1.1.0
b2cac000 b2caf000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
b2cb6000 b2cb7000 rwxp /usr/lib/libsyspopup_caller.so.0.1.0
b2cb8000 b2ce9000 r-xp /usr/lib/libpulse.so.0.12.4
b2cf0000 b2cf1000 rwxp /usr/lib/libpulse.so.0.12.4
b2cf1000 b2d54000 r-xp /usr/lib/libasound.so.2.0.0
b2d5b000 b2d5e000 rwxp /usr/lib/libasound.so.2.0.0
b2d5e000 b2d61000 r-xp /usr/lib/libpulse-simple.so.0.0.3
b2d68000 b2d69000 rwxp /usr/lib/libpulse-simple.so.0.0.3
b2d69000 b2d6d000 r-xp /usr/lib/libascenario-0.2.so.0.0.0
b2d75000 b2d76000 rwxp /usr/lib/libascenario-0.2.so.0.0.0
b2d77000 b2d94000 r-xp /usr/lib/libavsysaudio.so.0.0.1
b2d9b000 b2d9c000 rwxp /usr/lib/libavsysaudio.so.0.0.1
b2d9c000 b2daa000 r-xp /usr/lib/libmmfsound.so.0.1.0
b2db1000 b2db2000 rwxp /usr/lib/libmmfsound.so.0.1.0
b2db2000 b2e4e000 r-xp /usr/lib/libgstreamer-0.10.so.0.30.0
b2e56000 b2e59000 rwxp /usr/lib/libgstreamer-0.10.so.0.30.0
b2e5a000 b2e9b000 r-xp /usr/lib/libgstbase-0.10.so.0.30.0
b2ea3000 b2ea4000 rwxp /usr/lib/libgstbase-0.10.so.0.30.0
b2ea4000 b2ead000 r-xp /usr/lib/libgstapp-0.10.so.0.25.0
b2eb4000 b2eb5000 rwxp /usr/lib/libgstapp-0.10.so.0.25.0
b2eb6000 b2ec3000 r-xp /usr/lib/libgstinterfaces-0.10.so.0.25.0
b2ecb000 b2ecc000 rwxp /usr/lib/libgstinterfaces-0.10.so.0.25.0
b2ecc000 b2ef8000 r-xp /usr/lib/libidn.so.11.5.44
b2f00000 b2f01000 rwxp /usr/lib/libidn.so.11.5.44
b2f01000 b2f0b000 r-xp /usr/lib/libcares.so.2.0.0
b2f12000 b2f13000 rwxp /usr/lib/libcares.so.2.0.0
b2f13000 b2f15000 r-xp /usr/lib/libXau.so.6.0.0
b2f1c000 b2f1d000 rwxp /usr/lib/libXau.so.6.0.0
b2f1e000 b2f2e000 r-xp /lib/libresolv-2.13.so
b2f2e000 b2f2f000 r-xp /lib/libresolv-2.13.so
b2f2f000 b2f30000 rwxp /lib/libresolv-2.13.so
b2f32000 b2f37000 r-xp /usr/lib/libffi.so.5.0.10
b2f3e000 b2f3f000 rwxp /usr/lib/libffi.so.5.0.10
b2f3f000 b2f49000 r-xp /usr/lib/libethumb.so.1.7.99
b2f50000 b2f51000 rwxp /usr/lib/libethumb.so.1.7.99
b2f51000 b2f95000 r-xp /usr/lib/libsndfile.so.1.0.25
b2f9d000 b2f9f000 rwxp /usr/lib/libsndfile.so.1.0.25
b2fa4000 b2fa6000 r-xp /usr/lib/libctxdata.so.0.0.0
b2fad000 b2fae000 rwxp /usr/lib/libctxdata.so.0.0.0
b2fae000 b2fbc000 r-xp /usr/lib/libremix.so.0.0.0
b2fc3000 b2fc4000 rwxp /usr/lib/libremix.so.0.0.0
b2fc4000 b2fcb000 r-xp /usr/lib/libembryo.so.1.7.99
b2fd3000 b2fd4000 rwxp /usr/lib/libembryo.so.1.7.99
b2fd4000 b2ff8000 r-xp /usr/lib/libjpeg.so.8.0.2
b2fff000 b3000000 rwxp /usr/lib/libjpeg.so.8.0.2
b3010000 b3012000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
b3019000 b301a000 rwxp /usr/lib/libgmodule-2.0.so.0.3200.3
b301b000 b301e000 r-xp /usr/lib/libmm_ta.so.0.0.0
b3025000 b3026000 rwxp /usr/lib/libmm_ta.so.0.0.0
b3026000 b3035000 r-xp /usr/lib/libICE.so.6.3.0
b303c000 b303d000 rwxp /usr/lib/libICE.so.6.3.0
b303f000 b3044000 r-xp /usr/lib/libSM.so.6.0.1
b304b000 b304c000 rwxp /usr/lib/libSM.so.6.0.1
b304c000 b3054000 r-xp /lib/libcrypt-2.13.so
b305b000 b305c000 r-xp /lib/libcrypt-2.13.so
b305c000 b305d000 rwxp /lib/libcrypt-2.13.so
b3084000 b3087000 r-xp /lib/libcap.so.2.21
b308e000 b308f000 rwxp /lib/libcap.so.2.21
b3090000 b3092000 r-xp /usr/lib/libiri.so
b3099000 b309a000 rwxp /usr/lib/libiri.so
b309a000 b30ab000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b30b3000 b30b4000 rwxp /usr/lib/libsecurity-server-commons.so.1.0.0
b30b4000 b30b6000 r-xp /usr/lib/libsystemd-daemon.so.0.0.1
b30bd000 b30be000 rwxp /usr/lib/libsystemd-daemon.so.0.0.1
b30be000 b30bf000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
b30c6000 b30c7000 rwxp /usr/lib/libgthread-2.0.so.0.3200.3
b30c8000 b30ca000 r-xp /usr/lib/libdeviced.so.0.1.0
b30d1000 b30d2000 rwxp /usr/lib/libdeviced.so.0.1.0
b30d2000 b30e8000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b30ef000 b30f0000 rwxp /usr/lib/libpkgmgr_parser.so.0.1.0
b30f0000 b30f2000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
b30f9000 b30fa000 rwxp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
b30fa000 b30fd000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
b3104000 b3105000 rwxp /usr/lib/libpkgmgr_installer_client.so.0.1.0
b3106000 b3117000 r-xp /usr/lib/libcom-core.so.0.0.1
b311e000 b311f000 rwxp /usr/lib/libcom-core.so.0.0.1
b311f000 b3122000 r-xp /usr/lib/libdevice-node.so.0.1
b3129000 b312a000 rwxp /usr/lib/libdevice-node.so.0.1
b312a000 b312e000 r-xp /usr/lib/libheynoti.so.0.0.2
b3135000 b3136000 rwxp /usr/lib/libheynoti.so.0.0.2
b3136000 b3138000 r-xp /usr/lib/libapp-checker.so.0.1.0
b313f000 b3140000 rwxp /usr/lib/libapp-checker.so.0.1.0
b3141000 b3144000 r-xp /usr/lib/libsmack.so.1.0.0
b314b000 b314c000 rwxp /usr/lib/libsmack.so.1.0.0
b314c000 b3198000 r-xp /usr/lib/libssl.so.1.0.0
b319f000 b31a4000 rwxp /usr/lib/libssl.so.1.0.0
b31a4000 b31a5000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b31ac000 b31ad000 rwxp /usr/lib/libmmfkeysound.so.0.0.0
b31ad000 b31b5000 r-xp /usr/lib/libmmfcommon.so.0.0.0
b31bc000 b31bd000 rwxp /usr/lib/libmmfcommon.so.0.0.0
b31be000 b31c2000 r-xp /usr/lib/libsysman.so.0.2.0
b31c9000 b31ca000 rwxp /usr/lib/libsysman.so.0.2.0
b31ca000 b31d2000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.0
b31d9000 b31da000 rwxp /usr/lib/libaudio-session-mgr.so.0.0.0
b31dd000 b31e0000 r-xp /usr/lib/libmmfsession.so.0.0.0
b31e7000 b31e8000 rwxp /usr/lib/libmmfsession.so.0.0.0
b31e8000 b322c000 r-xp /usr/lib/libmmfplayer.so.0.0.0
b3233000 b3234000 rwxp /usr/lib/libmmfplayer.so.0.0.0
b3235000 b323b000 r-xp /usr/lib/libUMP.so
b3242000 b3243000 rwxp /usr/lib/libUMP.so
b3244000 b3268000 r-xp /usr/lib/libicule.so.48.1
b3270000 b3271000 rwxp /usr/lib/libicule.so.48.1
b3271000 b3277000 r-xp /usr/lib/libxcb-render.so.0.0.0
b327e000 b327f000 rwxp /usr/lib/libxcb-render.so.0.0.0
b327f000 b3280000 r-xp /usr/lib/libxcb-shm.so.0.0.0
b3288000 b3289000 rwxp /usr/lib/libxcb-shm.so.0.0.0
b3289000 b32a0000 r-xp /lib/libexpat.so.1.5.2
b32a8000 b32aa000 rwxp /lib/libexpat.so.1.5.2
b32ab000 b32ae000 r-xp /usr/lib/libecore_input_evas.so.1.7.99
b32b5000 b32b6000 rwxp /usr/lib/libecore_input_evas.so.1.7.99
b32b6000 b32f3000 r-xp /usr/lib/libcurl.so.4.3.0
b32fb000 b32fd000 rwxp /usr/lib/libcurl.so.4.3.0
b32fd000 b3301000 r-xp /usr/lib/libecore_ipc.so.1.7.99
b3309000 b330a000 rwxp /usr/lib/libecore_ipc.so.1.7.99
b330a000 b3310000 r-xp /usr/lib/libXrender.so.1.3.0
b3317000 b3318000 rwxp /usr/lib/libXrender.so.1.3.0
b3318000 b331e000 r-xp /usr/lib/libXrandr.so.2.2.0
b3325000 b3326000 rwxp /usr/lib/libXrandr.so.2.2.0
b3327000 b3328000 r-xp /usr/lib/libXinerama.so.1.0.0
b3330000 b3331000 rwxp /usr/lib/libXinerama.so.1.0.0
b3331000 b333a000 r-xp /usr/lib/libXi.so.6.1.0
b3341000 b3342000 rwxp /usr/lib/libXi.so.6.1.0
b3342000 b3344000 r-xp /usr/lib/libXgesture.so.7.0.0
b334b000 b334c000 rwxp /usr/lib/libXgesture.so.7.0.0
b334c000 b334e000 r-xp /usr/lib/libXcomposite.so.1.0.0
b3355000 b3356000 rwxp /usr/lib/libXcomposite.so.1.0.0
b3356000 b335d000 r-xp /usr/lib/libXcursor.so.1.0.2
b3364000 b3365000 rwxp /usr/lib/libXcursor.so.1.0.2
b3366000 b3369000 r-xp /usr/lib/libXfixes.so.3.1.0
b3370000 b3371000 rwxp /usr/lib/libXfixes.so.3.1.0
b3371000 b3386000 r-xp /usr/lib/libxcb.so.1.1.0
b338d000 b338e000 rwxp /usr/lib/libxcb.so.1.1.0
b338e000 b3396000 r-xp /usr/lib/libemotion.so.1.7.99
b339d000 b339e000 rwxp /usr/lib/libemotion.so.1.7.99
b339e000 b33a3000 r-xp /usr/lib/libecore_fb.so.1.7.99
b33aa000 b33ac000 rwxp /usr/lib/libecore_fb.so.1.7.99
b33ac000 b33b4000 r-xp /usr/lib/libsf_common.so
b33bb000 b33bc000 rwxp /usr/lib/libsf_common.so
b33bd000 b349a000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
b34a1000 b34a4000 rwxp /usr/lib/libgio-2.0.so.0.3200.3
b34a5000 b34ea000 r-xp /usr/lib/libsoup-2.4.so.1.5.0
b34f1000 b34f3000 rwxp /usr/lib/libsoup-2.4.so.1.5.0
b34f3000 b3527000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
b352e000 b3530000 rwxp /usr/lib/libgobject-2.0.so.0.3200.3
b3530000 b354b000 r-xp /usr/lib/libecore_con.so.1.7.99
b3552000 b3553000 rwxp /usr/lib/libecore_con.so.1.7.99
b3554000 b355c000 r-xp /usr/lib/libethumb_client.so.1.7.99
b3563000 b3564000 rwxp /usr/lib/libethumb_client.so.1.7.99
b3565000 b356e000 r-xp /usr/lib/libedbus.so.1.7.99
b3575000 b3576000 rwxp /usr/lib/libedbus.so.1.7.99
b3576000 b3578000 r-xp /usr/lib/libefreet_trash.so.1.7.99
b357f000 b3580000 rwxp /usr/lib/libefreet_trash.so.1.7.99
b3580000 b3584000 r-xp /usr/lib/libefreet_mime.so.1.7.99
b358c000 b358d000 rwxp /usr/lib/libefreet_mime.so.1.7.99
b358d000 b35a3000 r-xp /usr/lib/libefreet.so.1.7.99
b35ab000 b35ac000 rwxp /usr/lib/libefreet.so.1.7.99
b35ad000 b3609000 r-xp /usr/lib/libedje.so.1.7.99
b3611000 b3613000 rwxp /usr/lib/libedje.so.1.7.99
b3613000 b3618000 r-xp /usr/lib/libecore_file.so.1.7.99
b361f000 b3620000 rwxp /usr/lib/libecore_file.so.1.7.99
b3621000 b3634000 r-xp /usr/lib/libeet.so.1.7.99
b363c000 b363d000 rwxp /usr/lib/libeet.so.1.7.99
b363d000 b4744000 r-xp /usr/lib/libicudata.so.48.1
b474b000 b474c000 rwxp /usr/lib/libicudata.so.48.1
b474c000 b474f000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b4756000 b4757000 rwxp /usr/lib/libSLP-db-util.so.0.1.0
b4757000 b475d000 r-xp /usr/lib/libxdgmime.so.1.1.0
b4764000 b4765000 rwxp /usr/lib/libxdgmime.so.1.1.0
b4765000 b4773000 r-xp /usr/lib/libail.so.0.1.0
b477a000 b477b000 rwxp /usr/lib/libail.so.0.1.0
b477c000 b47a1000 r-xp /usr/lib/libexif.so.12.3.3
b47a8000 b47b5000 rwxp /usr/lib/libexif.so.12.3.3
b47b5000 b4800000 r-xp /usr/lib/libtiff.so.5.1.0
b4808000 b480b000 rwxp /usr/lib/libtiff.so.5.1.0
b480b000 b4834000 r-xp /usr/lib/libturbojpeg.so
b483c000 b483d000 rwxp /usr/lib/libturbojpeg.so
b484d000 b4853000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
b485a000 b485b000 rwxp /usr/lib/libmmutil_imgp.so.0.0.0
b485b000 b4861000 r-xp /usr/lib/libgif.so.4.1.6
b4868000 b4869000 rwxp /usr/lib/libgif.so.4.1.6
b4869000 b488b000 r-xp /usr/lib/libavutil.so.51.73.101
b4893000 b4896000 rwxp /usr/lib/libavutil.so.51.73.101
b489b000 b48c9000 r-xp /usr/lib/libswscale.so.2.1.101
b48d1000 b48d2000 rwxp /usr/lib/libswscale.so.2.1.101
b48d2000 b4bc9000 r-xp /usr/lib/libavcodec.so.54.59.100
b4bd1000 b4be1000 rwxp /usr/lib/libavcodec.so.54.59.100
b4ef0000 b4f09000 r-xp /usr/lib/libpng12.so.0.50.0
b4f11000 b4f12000 rwxp /usr/lib/libpng12.so.0.50.0
b4f12000 b4f1f000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b4f27000 b4f28000 rwxp /usr/lib/libprivilege-control.so.0.0.2
b4f28000 b507b000 r-xp /usr/lib/libcrypto.so.1.0.0
b5083000 b5096000 rwxp /usr/lib/libcrypto.so.1.0.0
b509a000 b50af000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b50b7000 b50b8000 rwxp /usr/lib/libsecurity-server-client.so.1.0.1
b50b8000 b50bc000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
b50c3000 b50c4000 rwxp /usr/lib/libcapi-system-info.so.0.2.0
b50c4000 b50c9000 r-xp /usr/lib/libcapi-system-system-settings.so.0.0.2
b50d0000 b50d1000 rwxp /usr/lib/libcapi-system-system-settings.so.0.0.2
b50d1000 b50d2000 r-xp /usr/lib/libcapi-system-power.so.0.1.1
b50da000 b50db000 rwxp /usr/lib/libcapi-system-power.so.0.1.1
b50db000 b50de000 r-xp /usr/lib/libcapi-system-device.so.0.1.0
b50e5000 b50e6000 rwxp /usr/lib/libcapi-system-device.so.0.1.0
b50e7000 b50ea000 r-xp /usr/lib/libcapi-network-serial.so.0.0.8
b50f1000 b50f2000 rwxp /usr/lib/libcapi-network-serial.so.0.0.8
b50f2000 b50f3000 r-xp /usr/lib/libcapi-content-mime-type.so.0.0.2
b50fa000 b50fb000 rwxp /usr/lib/libcapi-content-mime-type.so.0.0.2
b50fb000 b511d000 r-xp /usr/lib/libSLP-tapi.so.0.0.0
b5124000 b5125000 rwxp /usr/lib/libSLP-tapi.so.0.0.0
b5125000 b513c000 r-xp /lib/libz.so.1.2.5
b5143000 b5144000 rwxp /lib/libz.so.1.2.5
b5144000 b5147000 r-xp /usr/lib/libuuid.so.1.3.0
b514f000 b5150000 rwxp /usr/lib/libuuid.so.1.3.0
b5151000 b51bb000 r-xp /usr/lib/libsqlite3.so.0.8.6
b51c2000 b51c4000 rwxp /usr/lib/libsqlite3.so.0.8.6
b51c5000 b51e3000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b51ea000 b51eb000 rwxp /usr/lib/libpkgmgr-info.so.0.0.17
b51eb000 b5217000 r-xp /usr/lib/libdbus-1.so.3.7.2
b521f000 b5220000 rwxp /usr/lib/libdbus-1.so.3.7.2
b5220000 b5238000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b5238000 b5239000 rwxp /usr/lib/libdbus-glib-1.so.2.2.2
b5239000 b523a000 r-xp /usr/lib/libdlog.so.0.0.0
b5241000 b5242000 rwxp /usr/lib/libdlog.so.0.0.0
b5242000 b5259000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
b5261000 b5262000 rwxp /usr/lib/libpkgmgr-client.so.0.1.68
b5263000 b5264000 r-xp /usr/lib/libpmapi.so.1.2
b526b000 b526c000 rwxp /usr/lib/libpmapi.so.1.2
b526c000 b5270000 r-xp /usr/lib/libbundle.so.0.1.22
b5277000 b5278000 rwxp /usr/lib/libbundle.so.0.1.22
b5278000 b5288000 r-xp /usr/lib/libnotification.so.0.1.0
b528f000 b5290000 rwxp /usr/lib/libnotification.so.0.1.0
b5290000 b5298000 r-xp /usr/lib/libminizip.so.1.0.0
b529f000 b52a0000 rwxp /usr/lib/libminizip.so.1.0.0
b52a0000 b52ab000 r-xp /usr/lib/libmessage-port.so.1.2.2.1
b52b2000 b52b3000 rwxp /usr/lib/libmessage-port.so.1.2.2.1
b52b4000 b52d2000 r-xp /usr/lib/libpcre.so.0.0.1
b52d9000 b52da000 rwxp /usr/lib/libpcre.so.0.0.1
b52da000 b52dd000 r-xp /usr/lib/libiniparser.so.0
b52e4000 b52e5000 rwxp /usr/lib/libiniparser.so.0
b52e6000 b53ce000 r-xp /usr/lib/libicuuc.so.48.1
b53ce000 b53d9000 rwxp /usr/lib/libicuuc.so.48.1
b53db000 b54fb000 r-xp /usr/lib/libicui18n.so.48.1
b5502000 b5508000 rwxp /usr/lib/libicui18n.so.48.1
b5509000 b550d000 r-xp /usr/lib/libhaptic.so.0.1
b5514000 b5515000 rwxp /usr/lib/libhaptic.so.0.1
b5515000 b5520000 r-xp /usr/lib/libcryptsvc.so.0.0.1
b5528000 b5529000 rwxp /usr/lib/libcryptsvc.so.0.0.1
b552e000 b5533000 r-xp /usr/lib/libdevman.so.0.1
b553b000 b553c000 rwxp /usr/lib/libdevman.so.0.1
b553c000 b5547000 r-xp /usr/lib/libaul.so.0.1.0
b554f000 b5550000 rwxp /usr/lib/libaul.so.0.1.0
b5550000 b5551000 r-xp /usr/lib/osp/libappinfo.so.1.2.2.1
b5558000 b5559000 rwxp /usr/lib/osp/libappinfo.so.1.2.2.1
b5559000 b555f000 r-xp /usr/lib/libalarm.so.0.0.0
b5567000 b5568000 rwxp /usr/lib/libalarm.so.0.0.0
b5568000 b5571000 r-xp /usr/lib/libcapi-security-privilege-manager.so.0.0.3
b5579000 b557a000 rwxp /usr/lib/libcapi-security-privilege-manager.so.0.0.3
b557b000 b558d000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.5
b5594000 b5595000 rwxp /usr/lib/libprivacy-manager-client.so.0.0.5
b5595000 b559b000 r-xp /lib/librt-2.13.so
b55a2000 b55a3000 r-xp /lib/librt-2.13.so
b55a3000 b55a4000 rwxp /lib/librt-2.13.so
b55a4000 b560e000 r-xp /lib/libm-2.13.so
b5615000 b5616000 r-xp /lib/libm-2.13.so
b5616000 b5617000 rwxp /lib/libm-2.13.so
b5617000 b561b000 r-xp /usr/lib/libchromium.so.1.0
b5622000 b5623000 rwxp /usr/lib/libchromium.so.1.0
b5623000 b5626000 r-xp /usr/lib/libXtst.so.6.1.0
b562d000 b562e000 rwxp /usr/lib/libXtst.so.6.1.0
b562f000 b5636000 r-xp /usr/lib/libutilX.so.1.1.0
b563d000 b563e000 rwxp /usr/lib/libutilX.so.1.1.0
b563e000 b5641000 r-xp /usr/lib/libcapi-system-runtime-info.so.0.0.3
b5649000 b564a000 rwxp /usr/lib/libcapi-system-runtime-info.so.0.0.3
b564a000 b5663000 r-xp /usr/lib/liblua-5.1.so
b566b000 b566c000 rwxp /usr/lib/liblua-5.1.so
b566c000 b5670000 r-xp /usr/lib/libtbm.so.1.0.0
b5677000 b5678000 rwxp /usr/lib/libtbm.so.1.0.0
b5678000 b5680000 r-xp /usr/lib/libdrm.so.2.4.0
b5687000 b5688000 rwxp /usr/lib/libdrm.so.2.4.0
b5688000 b568a000 r-xp /usr/lib/libdri2.so.0.0.0
b5691000 b5692000 rwxp /usr/lib/libdri2.so.0.0.0
b5693000 b5699000 r-xp /usr/lib/libfeedback.so.0.1.4
b56a0000 b56a1000 rwxp /usr/lib/libfeedback.so.0.1.4
b56a1000 b56ad000 r-xp /usr/lib/libtts.so
b56b4000 b56b5000 rwxp /usr/lib/libtts.so
b56b5000 b56b8000 r-xp /usr/lib/libXv.so.1.0.0
b56bf000 b56c0000 rwxp /usr/lib/libXv.so.1.0.0
b56c0000 b57fd000 r-xp /usr/lib/libMali.so
b5805000 b580a000 rwxp /usr/lib/libMali.so
b580a000 b5814000 r-xp /usr/lib/libXext.so.6.4.0
b581c000 b581d000 rwxp /usr/lib/libXext.so.6.4.0
b581d000 b5879000 r-xp /usr/lib/libharfbuzz.so.0.907.0
b5881000 b588b000 rwxp /usr/lib/libharfbuzz.so.0.907.0
b588c000 b58a0000 r-xp /usr/lib/libfribidi.so.0.3.1
b58a7000 b58a8000 rwxp /usr/lib/libfribidi.so.0.3.1
b58a8000 b58fd000 r-xp /usr/lib/libfreetype.so.6.8.1
b5904000 b5908000 rwxp /usr/lib/libfreetype.so.6.8.1
b5908000 b59e2000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
b59ea000 b59eb000 rwxp /usr/lib/libglib-2.0.so.0.3200.3
b59eb000 b5a55000 r-xp /usr/lib/libpixman-1.so.0.28.2
b5a5d000 b5a62000 rwxp /usr/lib/libpixman-1.so.0.28.2
b5a62000 b5b19000 r-xp /usr/lib/libcairo.so.2.11200.12
b5b20000 b5b23000 rwxp /usr/lib/libcairo.so.2.11200.12
b5b23000 b5b47000 r-xp /usr/lib/libfontconfig.so.1.5.0
b5b4e000 b5b50000 rwxp /usr/lib/libfontconfig.so.1.5.0
b5b51000 b5c29000 r-xp /usr/lib/libxml2.so.2.7.8
b5c30000 b5c36000 rwxp /usr/lib/libxml2.so.2.7.8
b5c36000 b5c4d000 r-xp /usr/lib/libecore_input.so.1.7.99
b5c54000 b5c68000 rwxp /usr/lib/libecore_input.so.1.7.99
b5c68000 b5c69000 r-xp /usr/lib/libecore_imf_evas.so.1.7.99
b5c70000 b5c71000 rwxp /usr/lib/libecore_imf_evas.so.1.7.99
b5c71000 b5c76000 r-xp /usr/lib/libecore_imf.so.1.7.99
b5c7e000 b5c7f000 rwxp /usr/lib/libecore_imf.so.1.7.99
b5c7f000 b5caf000 r-xp /usr/lib/libecore_x.so.1.7.99
b5cb6000 b5cb8000 rwxp /usr/lib/libecore_x.so.1.7.99
b5cb9000 b5cd6000 r-xp /usr/lib/libecore_evas.so.1.7.99
b5cdd000 b5cdf000 rwxp /usr/lib/libecore_evas.so.1.7.99
b5cdf000 b5d1e000 r-xp /usr/lib/libeina.so.1.7.99
b5d25000 b5d27000 rwxp /usr/lib/libeina.so.1.7.99
b5d27000 b5dd6000 r-xp /usr/lib/libevas.so.1.7.99
b5dde000 b5de6000 rwxp /usr/lib/libevas.so.1.7.99
b5df8000 b5e0d000 r-xp /usr/lib/libecore.so.1.7.99
b5e15000 b5e16000 rwxp /usr/lib/libecore.so.1.7.99
b5e24000 b5e38000 r-xp /lib/libpthread-2.13.so
b5e3f000 b5e40000 r-xp /lib/libpthread-2.13.so
b5e40000 b5e41000 rwxp /lib/libpthread-2.13.so
b5e43000 b5e4c000 r-xp /usr/lib/libvconf.so.0.2.45
b5e53000 b5e54000 rwxp /usr/lib/libvconf.so.0.2.45
b5e54000 b5e55000 r-xp /usr/lib/libXdamage.so.1.1.0
b5e5d000 b5e5e000 rwxp /usr/lib/libXdamage.so.1.1.0
b5e5e000 b5f44000 r-xp /usr/lib/libX11.so.6.3.0
b5f4b000 b5f4f000 rwxp /usr/lib/libX11.so.6.3.0
b5f4f000 b606f000 r-xp /usr/lib/libelementary.so.1.7.99
b6076000 b607d000 rwxp /usr/lib/libelementary.so.1.7.99
b6081000 b608e000 r-xp /usr/lib/libsensor.so.1.1.0
b6096000 b6097000 rwxp /usr/lib/libsensor.so.1.1.0
b6099000 b609f000 r-xp /usr/lib/libappsvc.so.0.1.0
b60a6000 b60a7000 rwxp /usr/lib/libappsvc.so.0.1.0
b60a7000 b60ab000 r-xp /usr/lib/libappcore-efl.so.1.1
b60b2000 b60b3000 rwxp /usr/lib/libappcore-efl.so.1.1
b60b3000 b60b8000 r-xp /usr/lib/libappcore-common.so.1.1
b60bf000 b60c0000 rwxp /usr/lib/libappcore-common.so.1.1
b60c0000 b60ce000 r-xp /usr/lib/libcapi-appfw-application.so.0.1.0
b60d5000 b60d6000 rwxp /usr/lib/libcapi-appfw-application.so.0.1.0
b60d7000 b60f1000 r-xp /usr/lib/osp/libosp-image-core.so.1.2.2.0
b60f9000 b60fa000 rwxp /usr/lib/osp/libosp-image-core.so.1.2.2.0
b60fa000 b60fc000 r-xp /lib/libdl-2.13.so
b6103000 b6104000 r-xp /lib/libdl-2.13.so
b6104000 b6105000 rwxp /lib/libdl-2.13.so
b6105000 b6110000 r-xp /lib/libunwind.so.8.0.1
b6118000 b6119000 rwxp /lib/libunwind.so.8.0.1
b613e000 b625b000 r-xp /lib/libc-2.13.so
b6263000 b6265000 r-xp /lib/libc-2.13.so
b6265000 b6266000 rwxp /lib/libc-2.13.so
b6269000 b6272000 r-xp /lib/libgcc_s-4.5.3.so.1
b6279000 b627a000 rwxp /lib/libgcc_s-4.5.3.so.1
b627a000 b6315000 r-xp /usr/lib/libstdc++.so.6.0.14
b631d000 b6320000 r-xp /usr/lib/libstdc++.so.6.0.14
b6320000 b6322000 rwxp /usr/lib/libstdc++.so.6.0.14
b6328000 b6627000 r-xp /usr/lib/osp/libosp-appfw.so.1.2.2.1
b662f000 b664d000 rwxp /usr/lib/osp/libosp-appfw.so.1.2.2.1
b664e000 b6f49000 r-xp /usr/lib/osp/libosp-uifw.so.1.2.2.1
b6f50000 b6fb9000 rwxp /usr/lib/osp/libosp-uifw.so.1.2.2.1
b6fbc000 b6fbd000 r-xs /var/cache/fontconfig/3830d5c3ddfd5cd38a049b759396e72e-le32d8.cache-3
b6fbe000 b6fbf000 r-xp /usr/share/locale/en_GB/LC_MESSAGES/libc.mo
b6fbf000 b6fc0000 r-xp /usr/lib/locale/locale-archive
b6fc0000 b6fc1000 r-xp /usr/lib/locale/locale-archive
b6fc1000 b6fc6000 r-xp /usr/lib/libslp_devman_plugin.so
b6fcd000 b6fce000 rwxp /usr/lib/libslp_devman_plugin.so
b6fce000 b6fd2000 r-xp /usr/lib/libsys-assert.so
b6fd9000 b6fda000 rwxp /usr/lib/libsys-assert.so
b6fda000 b6ff7000 r-xp /lib/ld-2.13.so
b6ffe000 b6fff000 r-xp /lib/ld-2.13.so
b6fff000 b7000000 rwxp /lib/ld-2.13.so
befdf000 bf000000 rwxp [stack]
End of Maps Information

Callstack Information (PID:3000)
Call Stack Count: 39
 0: fclose + 0x8 (0xb6195110) [/lib/libc.so.6] + 0x57110
 1: (0x2a004498) [/opt/apps/kfYcpFyaST/bin/Argos1.1] + 0x4498
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
