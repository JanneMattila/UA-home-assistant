# UA-home-assistant

This project shows how to use the OPC UA information model to expose Home Assistant data to OPC UA clients.

## How to use it

### Compile the information model

The information model is defined in the [ModelDesign.xml](./src/UA-home-assistant-server/OPCUAModel/ModelDesign.xml) file. It is compiled using the Model Compiler:

```bash
.\Opc.Ua.ModelCompiler.exe compile -d2 "src\UA-home-assistant-server\OPCUAModel\ModelDesign.xml" -o2 "src\UA-home-assistant-server\HomeAssistant" -cg "src\UA-home-assistant-server\HomeAssistant\ModelDesign.csv"
```

## Links

### OPC UA

[Fundamentals of OPC UA](https://www.youtube.com/playlist?list=PLIrJJXPVFRvjHsA9tta8yULOB8nPUO_G7)

[Model Compiler](https://github.com/OPCFoundation/UA-ModelCompiler/)

[UA Modelling Best Practices](https://opcfoundation.org/wp-content/uploads/2020/09/OPC-11030-Whitepaper-UA-Modeling-Best-Practices-1.00.00.pdf)

[UA Edge Translator](https://github.com/OPCFoundation/UA-EdgeTranslator)

[OPC UA Information Model Tutorial](https://opcua.rocks/from-modelling-to-execution-opc-ua-information-model-tutorial/)

### Home Assistant

[WebSocket API](https://developers.home-assistant.io/docs/api/websocket/)

[HassClient](https://github.com/vicfergar/HassClient)

[Webhook](https://www.home-assistant.io/integrations/template/#trigger-based-sensor-and-binary-sensor-storing-webhook-information)
