
from pymodbus.client.sync import ModbusSerialClient

port = "COM3"
timeout = 1
baudrate = 19200
parity = "N"
stopbits = 1
bytesize = 8
slave_unit = 1
outdoor_temp_registr = 3301
room1_temp_registr = 204



def read_input(register):
    result = client.read_input_registers(register, 1, unit=slave_unit)
    #print((result.registers) + degree)
    string=" ".join ([str(item) for item in result.registers])
    my_str = string
    my_str = my_str[:2] + "," + my_str[2:]
    print(my_str)

client = ModbusSerialClient(method='rtu', port=port, timeout=timeout,
                                   baudrate=baudrate, parity=parity,
                                   stopbits=stopbits,bytesize=bytesize)

conn_status = client.connect()

read_input(outdoor_temp_registr)

client.close()

