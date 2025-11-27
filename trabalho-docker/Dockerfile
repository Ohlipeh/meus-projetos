# Usa uma imagem leve do Node.js
FROM node:18-alpine

# Cria a pasta de trabalho dentro do container
WORKDIR /app

# Copia o seu arquivo para dentro do container
COPY server.js .

# Expõe a porta 3000
EXPOSE 3000

# Comando para rodar o app
CMD ["node", "server.js"]