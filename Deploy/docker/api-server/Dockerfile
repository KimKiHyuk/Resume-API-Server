FROM mcr.microsoft.com/dotnet/core/runtime:3.0

RUN mkdir -p /usr/config
WORKDIR /usr/config
COPY . /usr/config

RUN chmod +x /usr/config/start.sh

ENTRYPOINT ["./start.sh"]

CMD ["tail -f /dev/null"]
