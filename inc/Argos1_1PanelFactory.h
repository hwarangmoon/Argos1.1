#ifndef _ARGOS_1___1_PANEL_FACTORY_H_
#define _ARGOS_1___1_PANEL_FACTORY_H_

#include <FApp.h>
#include <FBase.h>
#include <FSystem.h>
#include <FUi.h>
#include <FUiIme.h>
#include <FGraphics.h>
#include <gl.h>

class Argos1_1PanelFactory
	: public Tizen::Ui::Scenes::IPanelFactory
{
public:
	Argos1_1PanelFactory(void);
	virtual ~Argos1_1PanelFactory(void);

	virtual Tizen::Ui::Controls::Panel* CreatePanelN(const Tizen::Base::String& panelId, const Tizen::Ui::Scenes::SceneId& sceneId);
};

#endif // _ARGOS_1___1_PANEL_FACTORY_H_
