#ifndef _ARGOS_1___1_FORM_FACTORY_H_
#define _ARGOS_1___1_FORM_FACTORY_H_

#include <FApp.h>
#include <FBase.h>
#include <FSystem.h>
#include <FUi.h>
#include <FUiIme.h>
#include <FGraphics.h>
#include <gl.h>

class Argos1_1FormFactory
	: public Tizen::Ui::Scenes::IFormFactory
{
public:
	Argos1_1FormFactory(void);
	virtual ~Argos1_1FormFactory(void);

	virtual Tizen::Ui::Controls::Form* CreateFormN(const Tizen::Base::String& formId, const Tizen::Ui::Scenes::SceneId& sceneId);
};

#endif // _ARGOS_1___1_FORM_FACTORY_H_
