from Crypto.Cipher import AES
from cryptography.hazmat.primitives.asymmetric import rsa
from cryptography.hazmat.primitives import serialization
import sys

# Create a object cipher AES in mode ECB
def aes_encryption():
    # key 16 bytes
    key = b'Dieciseis  bytes'

    # Create a object cipher AES in mode EAX
    cipher = AES.new(key, AES.MODE_EAX)

    # Encrypt the message
    message = b'Hola Vista Alegre'

    # Cipher and obtain the ciphertext and authentication tag
    ciphertext, tag = cipher.encrypt_and_digest(message)

    print("Cifrado con AES en modo EAX")
    print("Texto cifrado", ciphertext.hex())

def rsa_encryption():
    # Generate RSA key pair
    private_key = rsa.generate_private_key(
        public_exponent=65537,
        key_size=2048,
    )

    # Get public key
    public_key = private_key.public_key()

    # Serialize public key
    private_pem = private_key.private_bytes(
        encoding=serialization.Encoding.PEM,
        format=serialization.PrivateFormat.TraditionalOpenSSL,
        encryption_algorithm=serialization.NoEncryption()
    )

    public_pem = public_key.public_bytes(
        encoding=serialization.Encoding.PEM,
        format=serialization.PublicFormat.SubjectPublicKeyInfo
    )

    print("Clave privada RSA:")
    print(private_pem.decode('utf-8'))

    print("Clave pública RSA:")
    print(public_pem.decode('utf-8'))

if __name__ == "__main__":
    option = input("Elija el método de cifrado, escriba: AES o RSA para obtener el cifrado deseado: ").strip().upper()

    if option == "AES":
        aes_encryption()
    elif option == "RSA":
        rsa_encryption()
    else:
        print("Opción no válida")
        sys.exit(1)


