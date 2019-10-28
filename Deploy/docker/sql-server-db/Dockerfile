FROM microsoft/mssql-server-linux:2017-latest

RUN mkdir -p /usr/config
WORKDIR /usr/config
COPY . /usr/config

RUN chmod +x /usr/config/start.sh

ENTRYPOINT ["./start.sh"]

CMD ["tail -f /dev/null"]