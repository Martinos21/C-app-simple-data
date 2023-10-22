from pymodbus.client.sync import ModbusTcpClient



port = "COM3"
timeout = 1
baudrate = 19200
parity = "N"
stopbits = 1
bytesize = 8
slave_unit = 1

room1_air_temp_register = 104

def read_input(register):
    result = client.read_input_registers(register, 1, unit=slave_unit)
    #print((result.registers) + degree)
    string=" ".join ([str(item) for item in result.registers])
    my_str = string
    my_str = my_str[:2] + "," + my_str[2:]
    print(my_str)

client = ModbusTcpClient("192.168.0.111")

conn_status = client.connect()

read_input(room1_air_temp_register)

client.close()